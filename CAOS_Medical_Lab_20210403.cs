/* 
*  DB Script Tool
*  C# Entity Framework (C#) - 2021-04-03 10:24:52
*  
*  MODEL CLASSES FOR CAOS_Medical_Lab DATABASE
*/



/* CAOS.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CAOS_Medical_Lab.Models 
{

    /// <summary>
    ///  C# - Model Class - CAOS_Medical_Lab.CAOS
    ///  2021-03-02 16:03:55
    /// </summary>
    //[Table("CAOS")]
    public class CAOS {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   CAOS myCAOS = new CAOS();
       ///   </code>
       /// </example>
        public CAOS() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   CAOS myCAOS = new CAOS( val1, val2,.. );
       ///   </code>
       /// </example>
        public CAOS(long _id, bool chemspider, double volume, double water, decimal urineph, long animalmodels, long chimpanzeeanimalmodels, long batanimalmodels, double temperaturedegreescelsius, decimal sodium, decimal glucose, decimal molecularweight) {
            this._id = _id;
            this.Chemspider = chemspider;
            this.Volume = volume;
            this.Water = water;
            this.Urineph = urineph;
            this.Animalmodels = animalmodels;
            this.Chimpanzeeanimalmodels = chimpanzeeanimalmodels;
            this.Batanimalmodels = batanimalmodels;
            this.Temperaturedegreescelsius = temperaturedegreescelsius;
            this.Sodium = sodium;
            this.Glucose = glucose;
            this.Molecularweight = molecularweight;
        }


        /**
        * Properties
        */

        [Required]
        public long _id { get; set; }

        public bool Chemspider { get; set; }

        public double Volume { get; set; }

        public double Water { get; set; }

        public decimal Urineph { get; set; }

        public long Animalmodels { get; set; }

        public long Chimpanzeeanimalmodels { get; set; }

        public long Batanimalmodels { get; set; }

        public double Temperaturedegreescelsius { get; set; }

        public decimal Sodium { get; set; }

        public decimal Glucose { get; set; }

        public decimal Molecularweight { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* IMHOTEP_Bizarros.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CAOS_Medical_Lab.Models 
{

    /// <summary>
    ///  C# - Model Class - CAOS_Medical_Lab.IMHOTEP_Bizarros
    ///  2021-03-02 16:20:32
    /// </summary>
    //[Table("IMHOTEP_Bizarros")]
    public class IMHOTEP_Bizarros {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   IMHOTEP_Bizarros myIMHOTEP_Bizarros = new IMHOTEP_Bizarros();
       ///   </code>
       /// </example>
        public IMHOTEP_Bizarros() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   IMHOTEP_Bizarros myIMHOTEP_Bizarros = new IMHOTEP_Bizarros( val1, val2,.. );
       ///   </code>
       /// </example>
        public IMHOTEP_Bizarros(int _id, long hospital, long clinic, long patient, long diagnosis, long diabetes, long prediabetes, long acutenephritis, long type1diabetes, long type2diabetes, decimal hypertension, decimal patientheight, decimal patientweight) {
            this._id = _id;
            this.Hospital = hospital;
            this.Clinic = clinic;
            this.Patient = patient;
            this.Diagnosis = diagnosis;
            this.Diabetes = diabetes;
            this.Prediabetes = prediabetes;
            this.Acutenephritis = acutenephritis;
            this.Type1diabetes = type1diabetes;
            this.Type2diabetes = type2diabetes;
            this.Hypertension = hypertension;
            this.Patientheight = patientheight;
            this.Patientweight = patientweight;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        public long Hospital { get; set; }

        public long Clinic { get; set; }

        public long Patient { get; set; }

        public long Diagnosis { get; set; }

        public long Diabetes { get; set; }

        public long Prediabetes { get; set; }

        public long Acutenephritis { get; set; }

        public long Type1diabetes { get; set; }

        public long Type2diabetes { get; set; }

        public decimal Hypertension { get; set; }

        public decimal Patientheight { get; set; }

        public decimal Patientweight { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* GENE_CRISpy.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CAOS_Medical_Lab.Models 
{

    /// <summary>
    ///  C# - Model Class - CAOS_Medical_Lab.GENE_CRISpy
    ///  
    /// </summary>
    //[Table("GENE_CRISpy")]
    public class GENE_CRISpy {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   GENE_CRISpy myGENE_CRISpy = new GENE_CRISpy();
       ///   </code>
       /// </example>
        public GENE_CRISpy() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   GENE_CRISpy myGENE_CRISpy = new GENE_CRISpy( val1, val2,.. );
       ///   </code>
       /// </example>
        public GENE_CRISpy(int _id, decimal gene, long virus, long cancer, decimal protein, decimal humancellmodel, decimal coronavirus, decimal sarscov2, decimal kidneystones, long pneumonia, decimal humanenzymes, decimal ghrelin, decimal obestatin, decimal breastcancergene, long disease, long cardiovasculardisease, long grampositivestain, long gramnegativestain, decimal denaturation, decimal dna, decimal rna, decimal lcarnitine, decimal aminoacid, byte kyotoencyclopediagenesgenomes) {
            this._id = _id;
            this.Gene = gene;
            this.Virus = virus;
            this.Cancer = cancer;
            this.Protein = protein;
            this.Humancellmodel = humancellmodel;
            this.Coronavirus = coronavirus;
            this.Sarscov2 = sarscov2;
            this.Kidneystones = kidneystones;
            this.Pneumonia = pneumonia;
            this.Humanenzymes = humanenzymes;
            this.Ghrelin = ghrelin;
            this.Obestatin = obestatin;
            this.Breastcancergene = breastcancergene;
            this.Disease = disease;
            this.Cardiovasculardisease = cardiovasculardisease;
            this.Grampositivestain = grampositivestain;
            this.Gramnegativestain = gramnegativestain;
            this.Denaturation = denaturation;
            this.Dna = dna;
            this.Rna = rna;
            this.Lcarnitine = lcarnitine;
            this.Aminoacid = aminoacid;
            this.Kyotoencyclopediagenesgenomes = kyotoencyclopediagenesgenomes;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        public decimal Gene { get; set; }

        public long Virus { get; set; }

        public long Cancer { get; set; }

        public decimal Protein { get; set; }

        public decimal Humancellmodel { get; set; }

        public decimal Coronavirus { get; set; }

        public decimal Sarscov2 { get; set; }

        public decimal Kidneystones { get; set; }

        public long Pneumonia { get; set; }

        public decimal Humanenzymes { get; set; }

        public decimal Ghrelin { get; set; }

        public decimal Obestatin { get; set; }

        public decimal Breastcancergene { get; set; }

        public long Disease { get; set; }

        public long Cardiovasculardisease { get; set; }

        public long Grampositivestain { get; set; }

        public long Gramnegativestain { get; set; }

        public decimal Denaturation { get; set; }

        public decimal Dna { get; set; }

        public decimal Rna { get; set; }

        public decimal Lcarnitine { get; set; }

        public decimal Aminoacid { get; set; }

        public byte Kyotoencyclopediagenesgenomes { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* ED_T_DOIDE.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CAOS_Medical_Lab.Models 
{

    /// <summary>
    ///  C# - Model Class - CAOS_Medical_Lab.ED_T_DOIDE
    ///  
    /// </summary>
    //[Table("ED_T_DOIDE")]
    public class ED_T_DOIDE {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   ED_T_DOIDE myED_T_DOIDE = new ED_T_DOIDE();
       ///   </code>
       /// </example>
        public ED_T_DOIDE() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   ED_T_DOIDE myED_T_DOIDE = new ED_T_DOIDE( val1, val2,.. );
       ///   </code>
       /// </example>
        public ED_T_DOIDE(int _id, decimal nutritionix, decimal mcdata, decimal kentuckyfriedchicken, decimal dominospizza, decimal edamam, int houndify) {
            this._id = _id;
            this.Nutritionix = nutritionix;
            this.Mcdata = mcdata;
            this.Kentuckyfriedchicken = kentuckyfriedchicken;
            this.Dominospizza = dominospizza;
            this.Edamam = edamam;
            this.Houndify = houndify;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        public decimal Nutritionix { get; set; }

        public decimal Mcdata { get; set; }

        public decimal Kentuckyfriedchicken { get; set; }

        public decimal Dominospizza { get; set; }

        public decimal Edamam { get; set; }

        public int Houndify { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* Hysteria_P_TRANCE.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CAOS_Medical_Lab.Models 
{

    /// <summary>
    ///  C# - Model Class - CAOS_Medical_Lab.Hysteria_P_TRANCE
    ///  
    /// </summary>
    //[Table("Hysteria_P_TRANCE")]
    public class Hysteria_P_TRANCE {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Hysteria_P_TRANCE myHysteria_P_TRANCE = new Hysteria_P_TRANCE();
       ///   </code>
       /// </example>
        public Hysteria_P_TRANCE() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Hysteria_P_TRANCE myHysteria_P_TRANCE = new Hysteria_P_TRANCE( val1, val2,.. );
       ///   </code>
       /// </example>
        public Hysteria_P_TRANCE(int _id, bool fitbit, decimal sleep, decimal weight, int heartrate, decimal dailyactivity, decimal waterintake, int tictok, int unity3d, int cosinemudbox) {
            this._id = _id;
            this.Fitbit = fitbit;
            this.Sleep = sleep;
            this.Weight = weight;
            this.Heartrate = heartrate;
            this.Dailyactivity = dailyactivity;
            this.Waterintake = waterintake;
            this.Tictok = tictok;
            this.Unity3d = unity3d;
            this.Cosinemudbox = cosinemudbox;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        public bool Fitbit { get; set; }

        public decimal Sleep { get; set; }

        public decimal Weight { get; set; }

        //[ForeignKey("IMHOTEP_Bizarros")]
        public int Heartrate { get; set; }
        public virtual IMHOTEP_Bizarros IMHOTEP_Bizarros { get; set; }

        public decimal Dailyactivity { get; set; }

        public decimal Waterintake { get; set; }

        //[ForeignKey("ED_T_DOIDE")]
        public int Tictok { get; set; }
        public virtual ED_T_DOIDE ED_T_DOIDE { get; set; }

        //[ForeignKey("Hysteria_P_TRANCE")]
        public int Unity3d { get; set; }
        public virtual Hysteria_P_TRANCE Hysteria_P_TRANCE { get; set; }

        //[ForeignKey("Hysteria_P_TRANCE")]
        public int Cosinemudbox { get; set; }
        public virtual Hysteria_P_TRANCE Hysteria_P_TRANCE { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* Dexcom.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CAOS_Medical_Lab.Models 
{

    /// <summary>
    ///  C# - Model Class - CAOS_Medical_Lab.Dexcom
    ///  
    /// </summary>
    //[Table("Dexcom")]
    public class Dexcom {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Dexcom myDexcom = new Dexcom();
       ///   </code>
       /// </example>
        public Dexcom() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Dexcom myDexcom = new Dexcom( val1, val2,.. );
       ///   </code>
       /// </example>
        public Dexcom(int _id, DateTime devices, String event, decimal calibrations) {
            this._id = _id;
            this.Devices = devices;
            this.Event = event;
            this.Calibrations = calibrations;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormatAttribute(ApplyFormatInEditMode = false, DataFormatString = "{0:yyyy-MM-dd HH:mm}")] //{0:hh:mm tt}
        public DateTime Devices { get; set; }

        [StringLength(10)]
        public String Event { get; set; }

        public decimal Calibrations { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* Sifidious.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CAOS_Medical_Lab.Models 
{

    /// <summary>
    ///  C# - Model Class - CAOS_Medical_Lab.Sifidious
    ///  
    /// </summary>
    //[Table("Sifidious")]
    public class Sifidious {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Sifidious mySifidious = new Sifidious();
       ///   </code>
       /// </example>
        public Sifidious() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Sifidious mySifidious = new Sifidious( val1, val2,.. );
       ///   </code>
       /// </example>
        public Sifidious(int _id, bool picturehumanmodelsubjects, bool pictureAnimalModels, bool witai) {
            this._id = _id;
            this.Picturehumanmodelsubjects = picturehumanmodelsubjects;
            this.PictureAnimalModels = pictureAnimalModels;
            this.Witai = witai;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        public bool Picturehumanmodelsubjects { get; set; }

        public bool PictureAnimalModels { get; set; }

        public bool Witai { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}