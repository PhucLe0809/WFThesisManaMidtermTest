﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ThesisManagementProject.Models;
using ThesisManagementProject.Process;

namespace ThesisManagementProject.Database
{
    #region THESISDAO STATUS

    public enum EThesisStatus
    {
        Pending,
        Accepted,
        Completed
    }

    #endregion

    internal class ThesisDAO
    {
        DBConnection DBConnection = new DBConnection();

        public ThesisDAO() { }

        public void SQLExecuteByCommand(string command)
        {
            DBConnection.SQLExecuteByCommand(command);
        }
        public void PendingToAccepted(string command)
        {
            DBConnection.SQLExecuteByCommand(command);
        }

        #region SELECT THESIS

        public List<Thesis> SelectList()
        {
            DataTable dataTable = DBConnection.Select(string.Format("SELECT * FROM {0}", MyDatabase.DBThesis));

            List<Thesis> list = new List<Thesis>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(GetFromDataRow(row));
            }

            return list;
        }
        public List<Thesis> SelectListByIDCreator(string idCreator)
        {
            DataTable dataTable = DBConnection.Select(string.Format("SELECT * FROM {0} WHERE idcreator = '{1}'", MyDatabase.DBThesis, idCreator));

            List<Thesis> list = new List<Thesis>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(GetFromDataRow(row));
            }

            return list;
        }
        public Thesis SelectOnly(string idThesis)
        {
            DBConnection db = new DBConnection();
            DataTable dt = db.Select(string.Format("SELECT * FROM {0} WHERE idthesis = '{1}'", MyDatabase.DBThesis, idThesis));

            if (dt.Rows.Count > 0) return GetFromDataRow(dt.Rows[0]);
            return new Thesis();
        }

        #endregion

        #region THESIS DAO EXECUTION

        public void Insert(Thesis thesis)
        {
            DBConnection.ExecuteQueryThesis(thesis, "INSERT INTO {0} " +
                "VALUES ('{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', {12}, {13}, {14}, {15})",
                "Create");
        }
        public void Delete(Thesis thesis)
        {
            DBConnection.ExecuteQueryThesis(thesis, "DELETE FROM {0} WHERE idthesis = '{1}'",
                "Delete");
        }
        public void Update(Thesis thesis)
        {
            DBConnection.ExecuteQueryThesis(thesis, "UPDATE {0} SET " +
                "idthesis = '{1}', topic = '{2}', field = '{3}', tslevel = '{4}', maxmembers = {5}, " +
                "description = '{6}', publishdate = '{7}', technology = '{8}', functions = '{9}', requirements = '{10}', " +
                "idcreator = '{11}', isfavorite = {12}, pending = {13}, accepted = {14}, completed = {15} WHERE idthesis = '{1}'",
                "Update");
        }

        #endregion

        #region Get Thesis From Data Row

        public Thesis GetFromDataRow(DataRow row)
        {
            string idThesis = row["idthesis"].ToString();
            string topic = row["topic"].ToString();
            EField field = MyProcess.GetEnumFromDisplayName<EField>(row["field"].ToString());
            ELevel level = MyProcess.GetEnumFromDisplayName<ELevel>(row["tslevel"].ToString());
            int maxMembers = int.Parse(row["maxmembers"].ToString());
            string description = row["description"].ToString();
            DateTime publishDate = DateTime.Parse(row["publishdate"].ToString());
            string technology = row["technology"].ToString();
            string functions = row["functions"].ToString();
            string requirements = row["requirements"].ToString();
            string idCreator = row["idcreator"].ToString();
            bool isFavorite = row["isfavorite"].ToString() == "True" ? true : false;
            int numPending = int.Parse(row["pending"].ToString());
            int numAccepted = int.Parse(row["accepted"].ToString());
            int numCompleted = int.Parse(row["completed"].ToString());

            Thesis thesis = new Thesis(idThesis, topic, field, level, maxMembers, description, publishDate, technology,
                                        functions, requirements, idCreator, isFavorite, numPending, numAccepted, numCompleted);
            return thesis;
        }

        #endregion

    }
}
