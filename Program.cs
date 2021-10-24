using System;
using System.Collections.Generic;

namespace Ex_Options
{
    class Program
    {
        static void Main(string[] args)

        {
            // le nombre des etudiants
            Console.WriteLine("Veuillez entrer le nombre des etudiants ");
            int NbrEt = int.Parse(Console.ReadLine());

            //creer les 3 options 
            Option GL = new Option();
            GL.Nom = "GL";
            Console.WriteLine("Veuillez entrez le nombre de places disponibles dans GL :");
            GL.PlacesDispo = int.Parse(Console.ReadLine());

            Option ABD = new Option();
            ABD.Nom = "ABD";
            Console.WriteLine("Veuillez entrez le nombre de places disponibles dans ABD :");
            ABD.PlacesDispo = int.Parse(Console.ReadLine());

            Option ASR = new Option();
            ASR.Nom = "ASR";
            Console.WriteLine("entrez le nombre de places disponibles dans ASR :");
            ASR.PlacesDispo = int.Parse(Console.ReadLine());

            //Afficher les 3 listes
            var ListeGL = new List<Etudiant>();
            var ListeABD = new List<Etudiant>();
            var ListeASR = new List<Etudiant>();

            //créer la liste des etudiants et leur choix
            var listEt = new List<Tuple<Etudiant, string, string, string>>();
             
            for (int i = 0; i < NbrEt; i++)
            {
                Console.WriteLine("Veuillez entrez le Nom de l'etudiant numero :" + (i + 1));
                string NomEt = Console.ReadLine();
                Console.WriteLine("Veuillez entrez le Prenom de l'etudiant numero :" + (i + 1));
                string PrenomEt = Console.ReadLine();
                Console.WriteLine("Veuillez entrez la note de l'etudiant numero :" + (i + 1)); 
                float NoteEt = float.Parse(Console.ReadLine());  
                Etudiant etudiant = new Etudiant(NomEt, PrenomEt, NoteEt);

                Console.WriteLine("Veuillez entrez le choix 1 ");
                string choix1 = Console.ReadLine();
                Console.WriteLine("Veuillez entrez le choix 2");
                string choix2 = Console.ReadLine();
                Console.WriteLine("Veuillez entrez le choix 3");
                string choix3 = Console.ReadLine();


                var tuple1 = Tuple.Create(etudiant, choix1, choix2, choix3);
                listEt.Add(tuple1);

            }

            // ordonner la liste des etudiant selon la note  
            listEt.Sort (delegate (Tuple<Etudiant, string, string, string> E1, Tuple<Etudiant, string, string, string> E2) {
                return E2.Item1.Note.CompareTo(E1.Item1.Note);
            });


            // Affectation des options 
            for (int j = 0; j < NbrEt; j++)
            {
                switch (listEt[j].Item2)
                {
                    case "GL":
                        if (GL.PlacesDispo > 0)
                        {
                            Etudiant item1 = listEt[j].Item1;
                            ListeGL.Add(item1);
                            --GL.PlacesDispo;
                        }
                        else
                        {

                            switch (listEt[j].Item3)
                            {
                                case "ABD":
                                    if (ABD.PlacesDispo > 0)
                                    {
                                        Etudiant item2 = listEt[j].Item1;
                                        ListeABD.Add(item2);
                                        --ABD.PlacesDispo;
                                    }
                                    else
                                    {
                                        if (listEt[j].Item4 == "ASR" && ASR.PlacesDispo > 0)
                                        {
                                            Etudiant item3 = listEt[j].Item1;
                                            ListeASR.Add(item3);
                                            --ASR.PlacesDispo;
                                        }
                                    }
                                    break;

                                case "ASR":
                                    if (ASR.PlacesDispo > 0)
                                    {
                                        Etudiant item2 = listEt[j].Item1;
                                        ListeASR.Add(item2);
                                        --ASR.PlacesDispo;
                                    }
                                    else
                                    {
                                        if (listEt[j].Item4 == "ABD" && ABD.PlacesDispo > 0)
                                        {
                                            Etudiant item3 = listEt[j].Item1;
                                            ListeABD.Add(item3);
                                            --ABD.PlacesDispo;
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                    case "ABD":
                        if (ABD.PlacesDispo > 0)
                        {
                            Etudiant item1 = listEt[j].Item1;
                            ListeABD.Add(item1);
                            --ABD.PlacesDispo;
                        }
                        else
                        {

                            switch (listEt[j].Item3)
                            {
                                case "GL":
                                    if (GL.PlacesDispo > 0)
                                    {
                                        Etudiant item2 = listEt[j].Item1;
                                        ListeGL.Add(item2);
                                        --GL.PlacesDispo;
                                    }
                                    else
                                    {
                                        if (listEt[j].Item4 == "ASR" && ASR.PlacesDispo > 0)
                                        {
                                            Etudiant item3 = listEt[j].Item1;
                                            ListeASR.Add(item3);
                                            --ASR.PlacesDispo;
                                        }
                                    }
                                    break;

                                case "ASR":
                                    if (ASR.PlacesDispo > 0)
                                    {
                                        Etudiant item2 = listEt[j].Item1;
                                        ListeASR.Add(item2);
                                        --ASR.PlacesDispo;
                                    }
                                    else
                                    {
                                        if (listEt[j].Item4 == "GL" && GL.PlacesDispo > 0)
                                        {
                                            Etudiant item3 = listEt[j].Item1;
                                            ListeGL.Add(item3);
                                            --GL.PlacesDispo;
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                    case "ASR":
                        if (ASR.PlacesDispo > 0)
                        {
                            Etudiant item1 = listEt[j].Item1;
                            ListeASR.Add(item1);
                            --ASR.PlacesDispo;
                        }
                        else
                        {

                            switch (listEt[j].Item3)
                            {
                                case "ABD":
                                    if (ABD.PlacesDispo > 0)
                                    {
                                        Etudiant item2 = listEt[j].Item1;
                                        ListeABD.Add(item2);
                                        --ABD.PlacesDispo;
                                    }
                                    else
                                    {
                                        if (listEt[j].Item4 == "GL" && GL.PlacesDispo > 0)
                                        {
                                            Etudiant item3 = listEt[j].Item1;
                                            ListeGL.Add(item3);
                                            --GL.PlacesDispo;
                                        }
                                    }
                                    break;

                                case "GL":
                                    if (GL.PlacesDispo > 0)
                                    {
                                        Etudiant item2 = listEt[j].Item1;
                                        ListeGL.Add(item2);
                                        --GL.PlacesDispo;
                                    }
                                    else
                                    {
                                        if (listEt[j].Item4 == "ABD" && ABD.PlacesDispo > 0)
                                        {
                                            Etudiant item3 = listEt[j].Item1;
                                            ListeABD.Add(item3);
                                            --ABD.PlacesDispo;
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                }

            }

            //Affichage des listes des options
            Console.WriteLine("la liste des etudiant admis GL :");
            foreach (Etudiant item in ListeGL)
            {
                Console.WriteLine(item.Nom + "\t" + item.Prenom +"\t" + item.Note);
            }
            Console.WriteLine("****************************************************");
            Console.WriteLine("la liste de l'option ABD :");
            foreach (Etudiant item1 in ListeABD)
            {
                Console.WriteLine(item1.Nom + "\t" + item1.Prenom + "\t" + item1.Note);
            }
            Console.WriteLine("****************************************************");
            Console.WriteLine("la liste de l'option ASR :");

            foreach (Etudiant item2 in ListeASR)
            {
                Console.WriteLine(item2.Nom + "\t" + item2.Prenom + "\t" + item2.Note);
            }
        }

    }
}
