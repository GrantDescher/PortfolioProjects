using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicLibrary
{
    public class AlbumsDAO
    {
        //  Create connection string
        string connString = @"Data Source=DESKTOP-R713QKE\SQLEXPRESS;Initial Catalog=GarthDB;Integrated Security=SSPI";

        public List<Album> getAllAlbums()
        {
            string term = "";
            //  Begin with an empty list
            List<Album> albumsToReturn = new List<Album>();

            //  Attempt to connect to SQL Server
            SqlConnection connection = new SqlConnection(connString);

            //  Open connection to server
            connection.Open();

            string searchPhrase = "%" + term + "%";

            //  Define SQL statement to get all albums
            SqlCommand command = new SqlCommand();
            command.CommandText =
                "SELECT * FROM albums WHERE AlbumName LIKE @term";
            command.Parameters.AddWithValue("@term", searchPhrase);
            command.Connection = connection;

            // Accesses the database and returns the albums as read only
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        Id = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumArtist = reader.GetString(2),
                        AlbumYear = reader.GetInt32(3),
                        AlbumDesc = reader.GetString(4),
                        AlbumURL = reader.GetString(5)
                    };

                    albumsToReturn.Add(a);
                }
            }

            //  Close connection to server
            connection.Close();

            return albumsToReturn;
        }

        // Based on the term inputted in the search text box, returns albums based on if they contain the term.
        public List<Album> getSearchAlbums(string search)
        {
            //  Begin with an empty list
            List<Album> albumsToReturn = new List<Album>();

            //  Attempt to connect to SQL Server
            SqlConnection connection = new SqlConnection(connString);

            //  Open connection to server
            connection.Open();

            string searchPhrase = "%" + search + "%";

            //  Define SQL statement to get all albums
            SqlCommand command = new SqlCommand();
            command.CommandText =
                "SELECT * FROM albums WHERE AlbumName LIKE @search";
            command.Parameters.AddWithValue("@search", searchPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        Id = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumArtist = reader.GetString(2),
                        AlbumYear = reader.GetInt32(3),
                        AlbumDesc = reader.GetString(4),
                        AlbumURL = reader.GetString(5)
                    };

                    albumsToReturn.Add(a);
                }
            }

            //  Close connection to server
            connection.Close();

            return albumsToReturn;
        }

        // Using the information inputted by the user in the textboxes in the bottom of the main form, adds a new album to the database.
        public int addNewAlbum(Album a)
        {
            //  Attempt to Connect to SQL Server
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //  Define SQL statement to insert the new album
            SqlCommand command = new SqlCommand(
                "INSERT INTO albums(albumName, albumArtist, albumYear, albumDesc, albumURL) " +
                "VALUES(@albumname, @albumartist, @albumyear, @albumdesc, @albumurl)",
                connection);
            command.Parameters.AddWithValue("@albumname", a.AlbumName);
            command.Parameters.AddWithValue("@albumartist", a.AlbumArtist);
            command.Parameters.AddWithValue("@albumyear", a.AlbumYear);
            command.Parameters.AddWithValue("@albumdesc", a.AlbumDesc);
            command.Parameters.AddWithValue("@albumURL", a.AlbumURL);

            int numRows = command.ExecuteNonQuery();
            connection.Close();

            return numRows;
        }

        // Display Songs for album in separate DGV
        public List<Songs> getSongsForAlbum(int albumID)
        {
            //  Begin with an empty list
            List<Songs> songsToReturn = new List<Songs>();

            //  Attempt to connect to SQL Server
            SqlConnection connection = new SqlConnection(connString);

            //  Open connection to server
            connection.Open();

            // Define SQL statement to get all albums
            SqlCommand command = new SqlCommand();
            command.CommandText =
                "SELECT * FROM songs WHERE AlbumID = @albumID";
            command.Parameters.AddWithValue("@albumID", albumID);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Songs s = new Songs
                    {
                        AlbumID = reader.GetInt32(0),
                        SongNumber = reader.GetInt32(1),
                        SongName = reader.GetString(2),
                        SongDuration = reader.GetString(3)
                    };

                    songsToReturn.Add(s);
                }
            }

            // Close connection to server
            connection.Close();

            return songsToReturn;
        }

        public List<AlbumFacts> getAlbumFacts(int albumID)
        {
            //  Begin with an empty list
            List<AlbumFacts> factsToReturn = new List<AlbumFacts>();

            //  Attempt to connect to SQL Server
            SqlConnection connection = new SqlConnection(connString);

            //  Open connection to server
            connection.Open();

            // Define SQL statement to get all albums
            SqlCommand command = new SqlCommand();
            command.CommandText =
                "SELECT * FROM albumFacts WHERE AlbumFactsID = @albumFactsID";
            command.Parameters.AddWithValue("@albumFactsID", albumID);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    AlbumFacts f = new AlbumFacts
                    {
                        AlbumID = reader.GetInt32(0),
                        AlbumReleaseDate = reader.GetString(1),
                        AlbumStudio = reader.GetString(2),
                        AlbumDuration = reader.GetString(3),
                        AlbumLabel = reader.GetString(4)
                    };

                    factsToReturn.Add(f);
                }
            }

            //  Close connection to server
            connection.Close();

            return factsToReturn;
        }
    }
}
