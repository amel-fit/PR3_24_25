﻿using DataTransferObjects;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
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
    public partial class frmStore : Form
    {
        private User LoggedUser { get; set; }
        private DataContext TinyStoreContext { get; set; }
        public frmStore()
        {
            InitializeComponent();
            dgvGames.AutoGenerateColumns = false;
            dgvGames.DataSource = null;
            dgvGames.DataSource = GetDTOGamesFromGames();

            lstGenres.DataSource = null;
            lstGenres.DataSource = DBActions.db.Genres.ToArray();
        }

        private List<dtoGameWithRating> GetDTOGamesFromGames()
        {
            var lstGames = DBActions.db.Games.ToArray();
            var lstGamesWithRating = new List<dtoGameWithRating>();
            foreach (var game in lstGames)
            {
                lstGamesWithRating.Add(new dtoGameWithRating(game));
            }
            return lstGamesWithRating;
        }

        public frmStore(User user) : this()
        {
            LoggedUser = user;
            lblUsername.Text = LoggedUser.UserName;
        }

        private void frmStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var SelectedGames = dgvGames.SelectedRows;
            for (int i = 0; i < SelectedGames.Count; i++)
            {
                if (SelectedGames[i]?.DataBoundItem is dtoGameWithRating dtoGame)
                {
                    var game = dtoGame.G;
                    //Game game = SelectedGames[i].DataBoundItem as Game;
                    UsersGame ug = new UsersGame()
                    {
                        //User data
                        User = LoggedUser,
                        UserId = LoggedUser.Id,

                        //Purchase Data
                        PurchaseDate = DateTime.Now,
                        IsGifted = false,
                        //Id = LoggedUser.UsersGames.Count, //let's not manually set the id :)

                        //Game data
                        Game = game,
                        GameId = game.Id,
                        //GameRatings = new List<GameRating>() //don't know what I gotta do here yet...
                    };
                    if (!UserHasGame(ug))
                    {
                        DBActions.AddUserGame(ug);
                        //LoggedUser.UsersGames.Add(ug);
                    }
                }
            }

        }

        private bool UserHasGame(UsersGame ug)
        {
            var gamesListOfUser = DBActions.GetUsersGamesList(ug.UserId);

            foreach (var Game in gamesListOfUser)
            {
                if (Game.Id == ug.GameId)
                    return true;
            }
            return false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var AdminPanel = new frmAdminPanel();
            AdminPanel.Show();
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            using (var sqlite = new ManualConnection())
            {
                sqlite.Connection.Open();
                var query = "CREATE TABLE Games (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Price REAL)";
                var command = new SqliteCommand(query, sqlite.Connection);
                command.ExecuteNonQuery();
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (var sqlite = new ManualConnection())
            {
                sqlite.Connection.Open();
                var query = "INSERT INTO Games (Name, Price) VALUES (@Name, @Price)";
                var command = new SqliteCommand(query, sqlite.Connection);
                command.Parameters.AddWithValue("@Name", "Ori and the Blind Forest");
                command.Parameters.AddWithValue("@Price", 20);
                command.ExecuteNonQuery();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var sqlite = new ManualConnection())
            {
                sqlite.Connection.Open();
                var query = "UPDATE Games SET Name = @Name WHERE Id = @Id";
                var command = new SqliteCommand(query, sqlite.Connection);
                command.Parameters.AddWithValue("@Name", "Ori and the Will of the Wisps");
                command.Parameters.AddWithValue("@Id", 1);
                command.ExecuteNonQuery();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var sqlite = new ManualConnection())
            {
                sqlite.Connection.Open();
                var query = "DELETE FROM Games WHERE Id = @Id";
                var command = new SqliteCommand(query, sqlite.Connection);
                command.Parameters.AddWithValue("@Id", 1);
                command.ExecuteNonQuery();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (var sqlite = new ManualConnection())
            {
                sqlite.Connection.Open();
                var query = "SELECT * FROM Games";
                var command = new SqliteCommand(query, sqlite.Connection);

                //we get a SQLite result
                var result = command.ExecuteReader();

                //we need to make it a list so we can display it 

                var lstGames = new List<Game>();

                while (result.Read())
                {
                    var Id = result.GetInt32(0);
                    var Name = result.GetString(1);
                    var Price = result.GetDecimal(2);

                    lstGames.Add(new Game()
                    {
                        Id = Id,
                        Name = Name,
                        Price = Price
                    });
                }

                // lstGames should just be set as the source of the dgv Games

            }
        }

        private void btnAssignGenres_Click(object sender, EventArgs e)
        {
            Game selectedGame = dgvGames.SelectedRows[0].DataBoundItem as Game;
            if (selectedGame == null) return;
            foreach (var item in lstGenres.SelectedItems)
            {
                var genre = item as Genre;
                var GameGenre = new GamesGenre()
                {
                    GameId = selectedGame.Id,
                    GenreId = genre.Id
                };
                if (!DBActions.GameHasGenre(GameGenre))
                    DBActions.AddGameGenre(GameGenre);
                else
                    MessageBox.Show($"{selectedGame.Name} already has {genre.Name}");
            }

        }
        private void dgvGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var game = dgvGames.SelectedRows[0].DataBoundItem as dtoGameWithRating;
            new frmGameInfo(game.G).Show();
        }
    }
}
