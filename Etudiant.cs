using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Options
{
    class Etudiant
    { 
        public string Nom;
        public string Prenom;
        public float Note;

        public Etudiant(string NomEt, string PrenomEt, float NoteEt)
        {
            Nom = NomEt;
            Prenom = PrenomEt;
            Note = NoteEt;
        }
    }
}
