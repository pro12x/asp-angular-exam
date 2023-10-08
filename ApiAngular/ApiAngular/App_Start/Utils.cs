using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using ApiAngular.Controllers;
using ApiAngular.Models;

namespace ApiAngular.App_Start
{
    public class Utils
    {
        bdAngularContext db = new bdAngularContext(); 

        /// <summary>
        /// permet de  journaliser les erreurs
        /// </summary>
        /// <param name="page">La page de l'erreur</param>
        /// <param name="fonction">la fonction</param>
        /// <param name="erreur">le message d'erreur</param>
        public void WriteDataError(string page, string fonction, string erreur)
        {
            try
            {
                TdLogErreur log = new TdLogErreur();
                log.DateErreur = DateTime.Now;
                log.Erreur = erreur.Length > 2000 ? erreur.Substring(0, 2000) : erreur;
                log.FonctionErreur = fonction;
                log.PageErreur = page;
                db.tdLogErreurs.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }



        public static void WriteFileError(string message)
        {
            try
            {
                string path = "";// Server.MapPath("~/Error/erreur.txt");
                System.IO.TextWriter writeFile = new StreamWriter(path, true);
                writeFile.WriteLine("" + DateTime.Now);
                writeFile.WriteLine(message);
                writeFile.WriteLine("---------------------------------------------------------------------------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteFileError");
            }
        }

        /// <summary>
        /// permet de jouraliser les erreurs dans systéme d'exploitation
        /// </summary>
        /// <param name="erreur">le message d'erreur</param>
        /// <param name="libelle">le libelle du message</param>
        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "gestion Couture";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
            }
        }
    }
}