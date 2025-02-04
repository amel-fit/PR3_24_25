﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyGameStore.Data;
using TinyGameStore.InMemory;

namespace TinyGameStore_G2
{
    public partial class frmRateGame : Form
    {
        Game GameToRate { get; set; }
        User UserThatRates { get; set; }
        DataContext TinyStoreContext { get; set; } = new();
        UsersGame UserGame { get; set; }
        public frmRateGame()
        {
            InitializeComponent();
        }
        public frmRateGame(Game g, User u) : this()
        {
            UserGame = DBActions.db.UsersGames.First(x => x.GameId == g.Id && x.UserId == u.Id);
            GameToRate = g;
            UserThatRates = u;
            lblGame.Text = g.Name;
            lblUserName.Text = u.UserName;
        }
        public frmRateGame(UsersGame ug) : this()
        {
            UserGame = ug;

            GameToRate = ug.Game;
            UserThatRates = ug.User;

            lblUserName.Text = ug.User.UserName;
            lblGame.Text = ug.Game.Name;

            var genres = Task.Run(GetGenresText);
            txtGenres.Text = genres.Result;
        }

        private async Task<string> GetGenresText()
        {
            
            var lstGenres = DBActions.db.GamesGenres.Where(gg => gg.GameId == GameToRate.Id).Select(gg => gg.Genre).ToArray();
            return string.Join(";", lstGenres.Select(x => x.Name).ToList());

        }


        private void btnRate_Click(object sender, EventArgs e)
        {
            var rating = new GameRating()
            { 
                UserGamesId = UserGame.Id,
                Rating = int.Parse(gbRatings.Controls.OfType<RadioButton>().First(rb => rb.Checked == true).Text)
            };
            //now to check if the user already rated this gamae
            if (!HasUserAlreadyRated(UserGame))
            {
                DBActions.db.GameRatings.Add(rating);
                //UserGame.GameRatings.Add(rating);
                DBActions.db.SaveChanges();

                MessageBox.Show("Test");
            }
            else
                MessageBox.Show("You have already rated this game");
        }

        private bool HasUserAlreadyRated(UsersGame userGame)
        {
            return DBActions.db.GameRatings.Where(gr => gr.UserGamesId == UserGame.Id).Any();
        }
        
        private void frmRateGame_Load(object sender, EventArgs e)
        {
            

        }
    }
}
