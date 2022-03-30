using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace objective_fit
{
	public class UsersRepository : Repository 
    {
        public UsersRepository() : base("users") 
        {
       
        }

		public void create(string registration, string name, string birthday, string gender, string adress, string phone, string email, string cpf)
        {
            string id = Guid.NewGuid().ToString();

            command.CommandText = String.Format("INSERT INTO users (id, registration, name, birthday, gender, adress, phone, email, cpf) " +
                   "VALUES ('{0}', {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');", id, registration, name, birthday, gender, adress, phone, email, cpf);
            var reader = command.ExecuteReader();
            reader.Close();
        }
		
		public void update(string id, string registration, string name, string birthday, string gender, string adress, string phone, string email, string cpf)
        {
            command.CommandText = String.Format("UPDATE users SET registration={0}, name='{1}', birthday='{2}', gender='{3}', adress='{4}', phone='{5}', email='{6}', cpf='{7}', updated_at='{8}' " +
                    "WHERE id='{9}'", registration, name, birthday, gender, adress, phone, email, cpf, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), id);
            command.ExecuteReader();
        }
	}
}