using Dapper;
using DapperMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMVC.DAL
{
    public class RoomService : BaseService
    {
        public RoomService() : base() { }
        public IEnumerable<Room> GetRooms()
        {
            List<Room> roomsList = new List<Room>();

            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                roomsList = con.Query<Room>("GetRoomDetails").ToList();
            }

            return roomsList;
        }
    }
}
