using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaugeV3;
using Org.BouncyCastle.Bcpg.OpenPgp;
using projetGauge_V3_Test.DAL;
using projetGauge_V3_Test.Model;
using projetGauge_V3_Test.Persistence;
using projetGauge_V3_Test.Service;

namespace projetGauge_V3_Test
{
    public partial class Form1 : Form
    {
        
        #region Attributes

        //Services
        private ThemeService themeService = new ThemeService(new ThemeDAO_InMemory());
        private DataService dataService = new DataService(new DataDAO_InMemory());

        
        private bool _settingPanelFlag;  //Flag pour le panneau
        private static int _divCounter;  // Counter pour les divisions
        #endregion


        // Properties
        #region Properties
        public static int DivCounter 
        {
            get { return _divCounter; }
            set { _divCounter = value; }
        }

        public bool SettingPanelFlag 
        {
            get { return _settingPanelFlag; } set { _settingPanelFlag = value; }
        }
        #endregion

        // Constructeurs
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            PopulateThemeComboBox();
            SettingPanelFlag = false;
            DivCounter = 5;

            // Empêcher le client de redimensionner la fenêtre lui-même
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        #endregion

        // Methodes personalisees 

        #region Methode ChangeDivision  //  Retour : void  //  Parametre : int
        public void ChangeDivisions(int newValue)
        {
            // Access a la propriete du nombre de division de la jauge
            gauge1.NoOfDivision = newValue;
            lbl_nbDiv.Text = newValue.ToString();

            // Le nombre de divisions est limité à 10 afin de préserver la lisibilité de la jauge
            // Le bouton pour diminuer est désactivé à 1, et celui pour augmenter est désactivé à 10.
            btn_DivPlus.Enabled = newValue < 10;
            btn_DivMinus.Enabled = newValue > 1;  
        }
        #endregion

        #region  Methode SetTheme  //  Retour : void  //  Parametre : string 
        public void SetTheme(string theme)
        {
            // Le texte de la comboBox est recherché parmi la liste du registre de themes
            // La comboBox est également générée à partir des clés de cette liste

            Theme tempTheme = themeService.GetThemeByTitle(theme);

            gauge1.GaugeHolderColor = tempTheme.GaugeHolderColor;  // Couleur du background de la jauge
            gauge1.GaugeColor = tempTheme.GaugeColor;  // Couleur de la jauge
            this.BackColor = tempTheme.BackColor; // Couleur du background de l'interface
            btn_Update.BackColor = tempTheme.ButtonColor;  // Couleur du background du bouton Afficher
            btn_Reset.ForeColor = tempTheme.ButtonColor;  // Couleur du background du bouton Reinitialiser
            btn_HideSettings.BackColor = tempTheme.ButtonColor;  //  Couleur du background du bouton pour afficher/masquer les parametres
            btn_DivMinus.BackColor = tempTheme.ButtonColor;  // Couleur du background du bouton (<) pour les divisions
            btn_DivPlus.BackColor = tempTheme.ButtonColor; // Couleur du background du bouton (>) pour les divisions 
            btn_Save.BackColor = tempTheme.ButtonColor; // Couleur du background du bouton Sauvegarder
            btn_Load.ForeColor = tempTheme.ButtonColor;  // Couleur du text du bouton Charger
            controlPanel.BackColor = tempTheme.Panels;  // Couleur du background du panneau de controle des valeurs
            panel_Settings.BackColor = tempTheme.Panels;  // Couleur du background du panneau de parametres
            gauge1.TextColor = tempTheme.TextColor;  // Couleur du text et des lignes de la regle de calibration
            lbl_InterfaceTitle.ForeColor = tempTheme.TextColor;  // Couleur du titre de l'interface
        }
        #endregion

        #region Methode PopulateThemeComboBox  //  Retour : void  //  Parametre : N/A
        private void PopulateThemeComboBox()
        {
            // Méthode simple pour peupler la liste des thèmes dans la ComboBox des thèmes
            // Ils sont directement extraits des clés de la liste du registre de themes

            foreach (var t in themeService.GetThemes())
            {
                comboBox1.Items.Add(t.ThemeName);
            }
        }
        #endregion

        #region Methode PopulateDataComboBox  //  Retour : void  //  Parametre : N/A
        private void PopulateDataComboBox()
        {
            // Nous commençons par vider la ComboBox pour éviter d'avoir les mêmes données deux fois
            comboBox_Data.Items.Clear();

            // Pour chaque donnée dans la liste registreData, nous ajoutons le timestamp (qui est converti en chaîne dans la classe Data)

            foreach (Data d in dataService.GetDataList())
            {
                comboBox_Data.Items.Add(d.Date);
            }

        }
        #endregion

        // Actions Boutons/ComboBox/CheckBox

        #region CheckBox SousDivisions CHECKED CHANGED
        private void checkBox_SubDivisions_CheckedChanged(object sender, EventArgs e)
        {
            // Lorsque la case à cocher SubDivision est activée, nous envoyons la valeur booléenne à la propriété ShowSubdivision du cadran
            gauge1.ShowSubDivision = checkBox_SubDivisions.Checked;
        }
        #endregion

        #region ComboBox Themes SELECTED INDEX CHANGED
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cette méthode est appelée chaque fois que l'index de la ComboBox des thèmes est modifié
            // Par exemple, si nous sélectionnons le 3ème index, cette méthode est appelée et appellera la méthode SetTheme

            this.SetTheme(comboBox1.Text);
        }
        #endregion

        #region Bouton Afficher CLICK
        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Vérifier si les valeurs entrées sont des chiffres
            if (double.TryParse(txtBox_CurrentValue.Text, out double currentValue) &&
                double.TryParse(txtBox_MinVal.Text, out double minValue) &&
                double.TryParse(txtBox_MaxVal.Text, out double maxValue))
            {
                // La méthode UpdateGauge du cadran est appelée avec les valeurs (current, min et max) en tant que paramètres
                gauge1.UpdateGauge(
                    txtBox_CurrentValue.Text,
                    txtBox_MinVal.Text,
                    txtBox_MaxVal.Text
                );

                // Lorsque le bouton Afficher est cliqué, les champs de texte se désactivent et le bouton Afficher également
                txtBox_CurrentValue.Enabled = false;
                txtBox_MinVal.Enabled = false;
                txtBox_MaxVal.Enabled = false;
                btn_Update.Enabled = false;
            }
            else
            {
                btn_Reset_Click(sender, e);
                // Afficher un message d'erreur si l'une des valeurs n'est pas un nombre valide
                MessageBox.Show("Veuillez entrer des valeurs numériques valides.");
            }
        }
        #endregion

        #region Bouton Reinitialiser CLICK
        private void btn_Reset_Click(object sender, EventArgs e)
        {

            // Nous mettons à jour le cadran avec les valeurs par défaut mais, surtout, en définissant la valeur actuelle à 0
            gauge1.UpdateGauge("0", "0", "100");

            
            txtBox_CurrentValue.Enabled = true; // Nous activons la zone de texte de la valeur actuelle
            txtBox_CurrentValue.Text = string.Empty; // Nous vidons la zone de texte de la valeur actuelle
            txtBox_CurrentValue.Focus(); // Nous mettons le focus sur la zone de texte de la valeur actuelle

            // Nous faisons la même chose pour la zone de texte de la valeur maximale
            txtBox_MaxVal.Enabled = true;  
            txtBox_MaxVal.Text = string.Empty;

            // Nous faisons la même chose pour la zone de texte de la valeur minimale
            txtBox_MinVal.Enabled = true;
            txtBox_MinVal.Text = string.Empty;

            // Nous activons les boutons Enregistrer et Mettre à jour
            btn_Save.Enabled = true;
            btn_Update.Enabled = true;
        }
        #endregion

        #region Bouton HideSettings CLICK
        private void btn_HideSettings_Click(object sender, EventArgs e)
        {
            // Si le panneau n'est pas masqué (si le drapeau est faux)
            if (!SettingPanelFlag)
            {
                panel_Settings.Enabled = false; // Nous désactivons le panneau
                this.Width = 867; // Nous redimensionnons la largeur pour que le panneau soit masqué
                SettingPanelFlag = true; // Nous définissons le flag à vrai (il est masqué)
                btn_HideSettings.Text = ">"; // Nous changeons le texte du bouton pour afficher la flèche d'ouverture
                return;

            }

            // Si le panneau est masqué (si le drapeau est vrai)
            if (SettingPanelFlag)
            {
                panel_Settings.Enabled = true; // Nous activons le panneau
                this.Width = 1126; // Nous redimensionnons la largeur pour que le panneau soit visible
                SettingPanelFlag = false; // Nous définissons le flag à faux (il n'est pas masqué)
                btn_HideSettings.Text = "<"; // Nous changeons le texte du bouton pour afficher la flèche de fermeture
                return;
            }

            // Notez que la largeur et la hauteur du formulaire sont verrouillées afin que l'utilisateur ne puisse pas redimensionner la fenêtre et afficher le panneau
        }
        #endregion

        #region Bouton DivMinus/DivPlus CLICK
        private void btn_DivMinus_Click(object sender, EventArgs e)
        {
            // Si la zone de texte des divisions n'est PAS inférieure ou égale à 1
            if (!(Int16.Parse(lbl_nbDiv.Text) <= 1))
            {
                // Nous diminuons le compteur de 1 et ensuite nous appelons la méthode ChangeDivision en envoyant le nouveau compteur
                this.ChangeDivisions(--DivCounter);
            }

            // Notez que la validation n'est pas vraiment nécessaire puisque le bouton est désactivé à 1
        }

        private void btn_DivPlus_Click(object sender, EventArgs e)
        {
            // Si la zone de texte des divisions n'est PAS supérieure ou égale à 10
            if (!(Int16.Parse(lbl_nbDiv.Text) >= 10))
            {
                // Nous augmentons le compteur de 1 et ensuite nous appelons la méthode ChangeDivision en envoyant le nouveau compteur
                this.ChangeDivisions(++DivCounter);
            }

            // Même remarque : la validation n'est pas vraiment nécessaire puisque le bouton est désactivé à 10
        }
        #endregion

        #region Bouton Sauvegarder CLICK
        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Le bouton Enregistrer ajoutera les nouvelles données à la liste registreData
            // Le constructeur de la nouvelle donnée ajoutera automatiquement la date et l'heure système à l'intérieur de l'objet (propriété)

            dataService.SaveData(
                new Data(
                    Double.Parse(txtBox_CurrentValue.Text), 
                    Double.Parse(txtBox_MaxVal.Text), 
                    Double.Parse(txtBox_MinVal.Text)
                )
            );

            MessageBox.Show("Enregistrement effectué avec succès."); // Nous confirmons que les données ont été enregistrées
            this.PopulateDataComboBox(); // Nous régénérons la ComboBox des données
            this.btn_Save.Enabled = false; // Nous désactivons le bouton Enregistrer pour éviter un enregistrement multiple
        }
        #endregion

        #region Bouton Charger CLICK
        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (comboBox_Data.SelectedIndex == -1)
            {
                MessageBox.Show("Aucun enregistrement n'a été sélectionné.");
                return;
            }
            // Nous récupérons les données qui correspondent au texte de la ComboBox dans un objet Data temporaire
            Data tempData = dataService.GetData(comboBox_Data.Text);

            // Si tempData n'est pas nul, nous mettons les valeurs de l'objet dans les TextBoxes
            if (tempData != null)
            {
                txtBox_CurrentValue.Text = Convert.ToString(tempData.CurrentValue);
                txtBox_MaxVal.Text = Convert.ToString(tempData.MaximumValue);
                txtBox_MinVal.Text = Convert.ToString(tempData.MinimumValue);

                // Nous mettons à jour le cadran avec les données chargées
                gauge1.UpdateGauge(
                    Convert.ToString(tempData.CurrentValue), 
                    Convert.ToString(tempData.MinimumValue), 
                    Convert.ToString(tempData.MaximumValue)
                );

                txtBox_CurrentValue.Enabled = false; // Nous désactivons la zone de texte de la valeur actuelle
                txtBox_MaxVal.Enabled = false; // Nous désactivons la zone de texte de la valeur maximale
                txtBox_MinVal.Enabled = false; // Nous désactivons la zone de texte de la valeur minimale

                // Nous désactivons également les boutons Afficher et Sauvegarder car il s'agit d'un enregistrement qui a ete charge (lecture seule)
                btn_Update.Enabled = false;
                btn_Save.Enabled = false;
            }

        }
        #endregion

        // Autres 

        #region UNUSED METHODS
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
