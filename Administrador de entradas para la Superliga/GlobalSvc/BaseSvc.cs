using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_de_entradas_para_la_Superliga.GlobalSvc
{
    class BaseSvc
    {
        private Entities1 entities = new Entities1();

        /// <summary>
        /// création d'une instance unique de la classe
        /// </summary>
        #region Instance
        private static readonly Lazy<BaseSvc> lazy = new Lazy<BaseSvc>(() => new BaseSvc());

        public static BaseSvc Instance { get { return lazy.Value; } }

        private BaseSvc()
        {
            
        }
        #endregion

        #region CRUD Socios

        /// <summary>
        /// Retourne la liste de tous les socios
        /// </summary>
        /// <returns></returns>
        private List<Socios> getListSocios()
        {
            return entities.Socios.ToList();
        }

        public Boolean getSociosByNumeroEtMdp(String numSocio, String mdp)
        {
            List<Socios> lS = getListSocios();
            foreach (Socios s in lS)
            {
                if (numSocio == s.numSocio && mdp == s.mdp)
                {
                    return true;
                }
            }

            return false;
           
        }
        #endregion

       

        #region CRUD Places

        public List<Places> getListPlaces()
        {
            return entities.Places.ToList();
        }
#endregion

        #region CRUD Matchs

        public List<Match> getListMatchs()
        {
            return entities.Match.ToList();
        }

        public List<Match> getListMatchsByIdMatch(int idMatch)
        {
            var query = from m in getListMatchs()
                where m.id == idMatch
                select m;
            return query.ToList();
        }
        

        #endregion


        #region CRUD Tribunes

        public List<Tribunes> getListTribunes()
        {
            return entities.Tribunes.ToList();
        }

        public int placeRestantesByTribunesEtMatch()
        {
           // List<Places> lesPlaces  
            return 1;
        }

        public void achatBillet(int idTribune, int idMatch)
        {
            // Nico
        }
        #endregion
    }
}
