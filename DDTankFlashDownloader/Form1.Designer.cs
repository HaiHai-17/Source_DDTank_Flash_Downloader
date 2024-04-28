namespace DDTankFlashDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFlashUrl = new System.Windows.Forms.Label();
            this.txtFlashUrl = new System.Windows.Forms.TextBox();
            this.lblFlashDil = new System.Windows.Forms.Label();
            this.txtFlashDil = new System.Windows.Forms.TextBox();
            this.listFlash = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.txtFlashDosyaAdi = new System.Windows.Forms.TextBox();
            this.lblFlashDosyaAdi = new System.Windows.Forms.Label();
            this.btnIndir = new System.Windows.Forms.Button();
            this.listDil = new System.Windows.Forms.ListBox();
            this.lblUrlFlash = new System.Windows.Forms.Label();
            this.lblUrlUi = new System.Windows.Forms.Label();
            this.listSwf = new System.Windows.Forms.ListBox();
            this.lblUrlSwf = new System.Windows.Forms.Label();
            this.listXml = new System.Windows.Forms.ListBox();
            this.lblUrlXml = new System.Windows.Forms.Label();
            this.btnSilDil = new System.Windows.Forms.Button();
            this.txtEkleDil = new System.Windows.Forms.TextBox();
            this.btnSilSwf = new System.Windows.Forms.Button();
            this.btnEkleSwf = new System.Windows.Forms.Button();
            this.txtEkleSwf = new System.Windows.Forms.TextBox();
            this.btnSilXml = new System.Windows.Forms.Button();
            this.btnEkleXml = new System.Windows.Forms.Button();
            this.txtEkleXml = new System.Windows.Forms.TextBox();
            this.btnEkleDil = new System.Windows.Forms.Button();
            this.gbDil = new System.Windows.Forms.GroupBox();
            this.cbDil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkvk = new System.Windows.Forms.LinkLabel();
            this.linkgszone = new System.Windows.Forms.LinkLabel();
            this.gbDil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFlashUrl
            // 
            this.lblFlashUrl.AutoSize = true;
            this.lblFlashUrl.Location = new System.Drawing.Point(17, 50);
            this.lblFlashUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlashUrl.Name = "lblFlashUrl";
            this.lblFlashUrl.Size = new System.Drawing.Size(76, 16);
            this.lblFlashUrl.TabIndex = 0;
            this.lblFlashUrl.Text = "Flash URL :";
            // 
            // txtFlashUrl
            // 
            this.txtFlashUrl.Location = new System.Drawing.Point(144, 47);
            this.txtFlashUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlashUrl.Name = "txtFlashUrl";
            this.txtFlashUrl.Size = new System.Drawing.Size(473, 22);
            this.txtFlashUrl.TabIndex = 1;
            // 
            // lblFlashDil
            // 
            this.lblFlashDil.AutoSize = true;
            this.lblFlashDil.Location = new System.Drawing.Point(17, 82);
            this.lblFlashDil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlashDil.Name = "lblFlashDil";
            this.lblFlashDil.Size = new System.Drawing.Size(79, 16);
            this.lblFlashDil.TabIndex = 2;
            this.lblFlashDil.Text = "Flash Lang :";
            // 
            // txtFlashDil
            // 
            this.txtFlashDil.Location = new System.Drawing.Point(144, 79);
            this.txtFlashDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlashDil.Name = "txtFlashDil";
            this.txtFlashDil.Size = new System.Drawing.Size(132, 22);
            this.txtFlashDil.TabIndex = 3;
            // 
            // listFlash
            // 
            this.listFlash.FormattingEnabled = true;
            this.listFlash.ItemHeight = 16;
            this.listFlash.Items.AddRange(new object[] {
            "1.png",
            "2.png",
            "3.png",
            "audio.swf",
            "audioii.swf",
            "catharine.swf",
            "characterdefine.xml",
            "DDT_Loading.swf",
            "Loading.swf",
            "partical.xml",
            "particallite.xml",
            "shape.swf",
            "shapelite.swf"});
            this.listFlash.Location = new System.Drawing.Point(11, 150);
            this.listFlash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listFlash.Name = "listFlash";
            this.listFlash.Size = new System.Drawing.Size(299, 116);
            this.listFlash.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(11, 274);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 28);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Удалить";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(111, 274);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(200, 28);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Добавить файл";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(111, 310);
            this.txtEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(199, 22);
            this.txtEkle.TabIndex = 8;
            // 
            // txtFlashDosyaAdi
            // 
            this.txtFlashDosyaAdi.Location = new System.Drawing.Point(144, 15);
            this.txtFlashDosyaAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlashDosyaAdi.Name = "txtFlashDosyaAdi";
            this.txtFlashDosyaAdi.Size = new System.Drawing.Size(132, 22);
            this.txtFlashDosyaAdi.TabIndex = 9;
            // 
            // lblFlashDosyaAdi
            // 
            this.lblFlashDosyaAdi.AutoSize = true;
            this.lblFlashDosyaAdi.Location = new System.Drawing.Point(17, 18);
            this.lblFlashDosyaAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlashDosyaAdi.Name = "lblFlashDosyaAdi";
            this.lblFlashDosyaAdi.Size = new System.Drawing.Size(121, 16);
            this.lblFlashDosyaAdi.TabIndex = 10;
            this.lblFlashDosyaAdi.Text = "Имя файла Flash :";
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(11, 352);
            this.btnIndir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(167, 43);
            this.btnIndir.TabIndex = 11;
            this.btnIndir.Text = "Начать загрузку !";
            this.btnIndir.UseVisualStyleBackColor = true;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // listDil
            // 
            this.listDil.FormattingEnabled = true;
            this.listDil.ItemHeight = 16;
            this.listDil.Items.AddRange(new object[] {
            "language.png",
            "language.txt",
            "levelreward.xml",
            "movingnotification.txt",
            "playerregressnotification.txt",
            "zhancode.txt"});
            this.listDil.Location = new System.Drawing.Point(319, 150);
            this.listDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listDil.Name = "listDil";
            this.listDil.Size = new System.Drawing.Size(299, 116);
            this.listDil.TabIndex = 14;
            // 
            // lblUrlFlash
            // 
            this.lblUrlFlash.AutoSize = true;
            this.lblUrlFlash.Location = new System.Drawing.Point(7, 130);
            this.lblUrlFlash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrlFlash.Name = "lblUrlFlash";
            this.lblUrlFlash.Size = new System.Drawing.Size(39, 16);
            this.lblUrlFlash.TabIndex = 15;
            this.lblUrlFlash.Text = "flash/";
            // 
            // lblUrlUi
            // 
            this.lblUrlUi.AutoSize = true;
            this.lblUrlUi.Location = new System.Drawing.Point(315, 130);
            this.lblUrlUi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrlUi.Name = "lblUrlUi";
            this.lblUrlUi.Size = new System.Drawing.Size(77, 16);
            this.lblUrlUi.TabIndex = 16;
            this.lblUrlUi.Text = "flash/ui/DİL/";
            // 
            // listSwf
            // 
            this.listSwf.FormattingEnabled = true;
            this.listSwf.ItemHeight = 16;
            this.listSwf.Items.AddRange(new object[] {
            "academy.swf",
            "academycommon.swf",
            "activeevents.swf",
            "auction.swf",
            "audio.swf",
            "avatarcollection.swf",
            "awardsystem.swf",
            "bagandinfo.swf",
            "baglocked.swf",
            "battleground.swf",
            "boguadventure.swf",
            "bombking.swf",
            "caddy.swf",
            "calendar.swf",
            "campbattle.swf",
            "cardsystem.swf",
            "catchbeast.swf",
            "catchinsect.swf",
            "challengeroom.swf",
            "changecolor.swf",
            "chat.swf",
            "chatball.swf",
            "chatii.swf",
            "chickactivation.swf",
            "choicefigure.swf",
            "christmas.swf",
            "churchroom.swf",
            "churchroomlist.swf",
            "civil.swf",
            "cloudBuy.swf",
            "collectiontask.swf",
            "consortia.swf",
            "consortiabattle.swf",
            "consortion.swf",
            "consortionclub.swf",
            "consortionii.swf",
            "core.swf",
            "corei.swf",
            "coreiconandtip.swf",
            "coreii.swf",
            "corescalebitmap.swf",
            "cryptBoss.swf",
            "cursor.swf",
            "daily.swf",
            "dayactivity.swf",
            "ddplay.swf",
            "ddtacademy.swf",
            "ddtauction.swf",
            "ddtawardsystem.swf",
            "ddtbagandinfo.swf",
            "ddtbaglocked.swf",
            "ddtbead.swf",
            "ddtburied.swf",
            "ddtcalendar.swf",
            "ddtcardsystem.swf",
            "ddtchurchroomlist.swf",
            "ddtcivil.swf",
            "ddtconsortion.swf",
            "ddtcorei.swf",
            "ddtcoreii.swf",
            "ddtcorescalebitmap.swf",
            "ddteffort.swf",
            "ddtelitegame.swf",
            "ddtemail.swf",
            "ddtfeedback.swf",
            "ddtgetticketview.swf",
            "ddtgiftsystem.swf",
            "ddthall.swf",
            "ddthallicon.swf",
            "ddthotspringroomlist.swf",
            "ddtim.swf",
            "ddtinvite.swf",
            "ddtlittlegame.swf",
            "ddtmainbtn.swf",
            "ddtregressview.swf",
            "ddtroom.swf",
            "ddtroomlist.swf",
            "ddtroomloading.swf",
            "ddtsetting.swf",
            "ddtshop.swf",
            "ddtstore.swf",
            "ddttexpsystem.swf",
            "ddttrainer.swf",
            "ddtvipview.swf",
            "defaultliving.swf",
            "dragonboat.swf",
            "dragonboatboatres.swf",
            "drgnboatbuild.swf",
            "drgnBoatframe.swf",
            "drgnBoatgame.swf",
            "drgnBoaticon.swf",
            "effort.swf",
            "elitegame.swf",
            "email.swf",
            "enchant.swf",
            "entertainmentmode.swf",
            "enthrall.swf",
            "escortframe.swf",
            "escortgame.swf",
            "escorticon.swf",
            "expression.swf",
            "farm.swf",
            "farmpettrainerui.swf",
            "feedback.swf",
            "fightfootballtime.swf",
            "fightlib.swf",
            "firstcore.swf",
            "firstrecharge.swf",
            "firsttainer.swf",
            "flowergiving.swf",
            "foodactivity.swf",
            "forgemain.swf",
            "game.swf",
            "game_DanderBackMovie.swf",
            "gameii.swf",
            "gameiii.swf",
            "gameover.swf",
            "gemstone.swf",
            "giftsystem.swf",
            "godsroads.swf",
            "gotopage.swf",
            "grouppurchase.swf",
            "growthpackage.swf",
            "guildmemberweek.swf",
            "gypsyshop.swf",
            "hall.swf",
            "halloween.swf",
            "horse.swf",
            "horseRace.swf",
            "hotspringroom.swf",
            "hotspringroomlist.swf",
            "im.swf",
            "integralshop.swf",
            "invite.swf",
            "kingbless.swf",
            "kingdivision.swf",
            "labyrinth.swf",
            "lanternriddles.swf",
            "latentenergy.swf",
            "league.swf",
            "levelicon.swf",
            "lightroad.swf",
            "littlegame.swf",
            "loading.swf",
            "loadingasset.swf",
            "login.swf",
            "lottery.swf",
            "luckstar.swf",
            "luckstaraction.swf",
            "magichouse.swf",
            "magicstone.swf",
            "magpiebridge.swf",
            "microenddownload.swf",
            "mysteriousroulette.swf",
            "newchickenbox.swf",
            "newfightlib.swf",
            "newhandopencartoon.swf",
            "newopenguide.swf",
            "newtitle.swf",
            "newversionguide.swf",
            "newyearrice.swf",
            "oldTrainer.swf",
            "oldTutorialstepassets.swf",
            "petsbag.swf",
            "playerdress.swf",
            "playertip.swf",
            "pyramid.swf",
            "quest.swf",
            "rescue.swf",
            "ringstation.swf",
            "roadcomponent.swf",
            "room.swf",
            "roomlist.swf",
            "roulette.swf",
            "serverList.swf",
            "setting.swf",
            "sevendaytarget.swf",
            "sevendoubleframe.swf",
            "sevendoublegame.swf",
            "sevendoubleicon.swf",
            "shop.swf",
            "store.swf",
            "superwinner.swf",
            "systemopenprompt.swf",
            "task.swf",
            "texpsystem.swf",
            "times.swf",
            "timesupdate.swf",
            "toffilist.swf",
            "toolbar.swf",
            "totem.swf",
            "trainer.swf",
            "trainer1.swf",
            "trainer2.swf",
            "trainer3.swf",
            "trainer4.swf",
            "trainer5.swf",
            "trainer6.swf",
            "trainerfirstgame.swf",
            "trainerui.swf",
            "treasure.swf",
            "treasurehunting.swf",
            "treasurelost.swf",
            "treasurepuzzle.swf",
            "tutorialstepassets.swf",
            "viplevelicon.swf",
            "vipview.swf",
            "wantstrong.swf",
            "weekly.swf",
            "witchblessing.swf",
            "wonderfulactivity.swf",
            "worldboss.swf",
            "worldbosshelper.swf",
            "worshipTheMoon.swf",
            "yyvip.swf",
            "zodiac.swf"});
            this.listSwf.Location = new System.Drawing.Point(627, 150);
            this.listSwf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listSwf.Name = "listSwf";
            this.listSwf.Size = new System.Drawing.Size(299, 116);
            this.listSwf.TabIndex = 17;
            // 
            // lblUrlSwf
            // 
            this.lblUrlSwf.AutoSize = true;
            this.lblUrlSwf.Location = new System.Drawing.Point(623, 130);
            this.lblUrlSwf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrlSwf.Name = "lblUrlSwf";
            this.lblUrlSwf.Size = new System.Drawing.Size(100, 16);
            this.lblUrlSwf.TabIndex = 18;
            this.lblUrlSwf.Text = "flash/ui/DİL/swf/";
            // 
            // listXml
            // 
            this.listXml.FormattingEnabled = true;
            this.listXml.ItemHeight = 16;
            this.listXml.Items.AddRange(new object[] {
            "xml.png"});
            this.listXml.Location = new System.Drawing.Point(935, 150);
            this.listXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listXml.Name = "listXml";
            this.listXml.Size = new System.Drawing.Size(299, 116);
            this.listXml.TabIndex = 19;
            // 
            // lblUrlXml
            // 
            this.lblUrlXml.AutoSize = true;
            this.lblUrlXml.Location = new System.Drawing.Point(931, 130);
            this.lblUrlXml.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrlXml.Name = "lblUrlXml";
            this.lblUrlXml.Size = new System.Drawing.Size(101, 16);
            this.lblUrlXml.TabIndex = 20;
            this.lblUrlXml.Text = "flash/ui/DİL/xml/";
            // 
            // btnSilDil
            // 
            this.btnSilDil.Location = new System.Drawing.Point(319, 274);
            this.btnSilDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSilDil.Name = "btnSilDil";
            this.btnSilDil.Size = new System.Drawing.Size(100, 28);
            this.btnSilDil.TabIndex = 6;
            this.btnSilDil.Text = "Удалить";
            this.btnSilDil.UseVisualStyleBackColor = true;
            this.btnSilDil.Click += new System.EventHandler(this.btnSilDil_Click);
            // 
            // txtEkleDil
            // 
            this.txtEkleDil.Location = new System.Drawing.Point(419, 310);
            this.txtEkleDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEkleDil.Name = "txtEkleDil";
            this.txtEkleDil.Size = new System.Drawing.Size(199, 22);
            this.txtEkleDil.TabIndex = 8;
            // 
            // btnSilSwf
            // 
            this.btnSilSwf.Location = new System.Drawing.Point(627, 274);
            this.btnSilSwf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSilSwf.Name = "btnSilSwf";
            this.btnSilSwf.Size = new System.Drawing.Size(100, 28);
            this.btnSilSwf.TabIndex = 21;
            this.btnSilSwf.Text = "Удалить";
            this.btnSilSwf.UseVisualStyleBackColor = true;
            this.btnSilSwf.Click += new System.EventHandler(this.btnSilSwf_Click);
            // 
            // btnEkleSwf
            // 
            this.btnEkleSwf.Location = new System.Drawing.Point(727, 274);
            this.btnEkleSwf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkleSwf.Name = "btnEkleSwf";
            this.btnEkleSwf.Size = new System.Drawing.Size(200, 28);
            this.btnEkleSwf.TabIndex = 22;
            this.btnEkleSwf.Text = "Добавить файл";
            this.btnEkleSwf.UseVisualStyleBackColor = true;
            this.btnEkleSwf.Click += new System.EventHandler(this.btnEkleSwf_Click);
            // 
            // txtEkleSwf
            // 
            this.txtEkleSwf.Location = new System.Drawing.Point(727, 310);
            this.txtEkleSwf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEkleSwf.Name = "txtEkleSwf";
            this.txtEkleSwf.Size = new System.Drawing.Size(199, 22);
            this.txtEkleSwf.TabIndex = 23;
            // 
            // btnSilXml
            // 
            this.btnSilXml.Location = new System.Drawing.Point(935, 274);
            this.btnSilXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSilXml.Name = "btnSilXml";
            this.btnSilXml.Size = new System.Drawing.Size(100, 28);
            this.btnSilXml.TabIndex = 21;
            this.btnSilXml.Text = "Удалить";
            this.btnSilXml.UseVisualStyleBackColor = true;
            this.btnSilXml.Click += new System.EventHandler(this.btnSilXml_Click);
            // 
            // btnEkleXml
            // 
            this.btnEkleXml.Location = new System.Drawing.Point(1035, 274);
            this.btnEkleXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkleXml.Name = "btnEkleXml";
            this.btnEkleXml.Size = new System.Drawing.Size(200, 28);
            this.btnEkleXml.TabIndex = 22;
            this.btnEkleXml.Text = "Добавить файл";
            this.btnEkleXml.UseVisualStyleBackColor = true;
            this.btnEkleXml.Click += new System.EventHandler(this.btnEkleXml_Click);
            // 
            // txtEkleXml
            // 
            this.txtEkleXml.Location = new System.Drawing.Point(1035, 310);
            this.txtEkleXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEkleXml.Name = "txtEkleXml";
            this.txtEkleXml.Size = new System.Drawing.Size(199, 22);
            this.txtEkleXml.TabIndex = 23;
            // 
            // btnEkleDil
            // 
            this.btnEkleDil.Location = new System.Drawing.Point(419, 274);
            this.btnEkleDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkleDil.Name = "btnEkleDil";
            this.btnEkleDil.Size = new System.Drawing.Size(200, 28);
            this.btnEkleDil.TabIndex = 24;
            this.btnEkleDil.Text = "Добавить файл";
            this.btnEkleDil.UseVisualStyleBackColor = true;
            this.btnEkleDil.Click += new System.EventHandler(this.btnEkleDil_Click);
            // 
            // gbDil
            // 
            this.gbDil.Controls.Add(this.cbDil);
            this.gbDil.Location = new System.Drawing.Point(627, 15);
            this.gbDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDil.Name = "gbDil";
            this.gbDil.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDil.Size = new System.Drawing.Size(267, 68);
            this.gbDil.TabIndex = 27;
            this.gbDil.TabStop = false;
            this.gbDil.Text = "Language";
            // 
            // cbDil
            // 
            this.cbDil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDil.FormattingEnabled = true;
            this.cbDil.Items.AddRange(new object[] {
            "Russian",
            "English",
            "Vietnam"});
            this.cbDil.Location = new System.Drawing.Point(8, 23);
            this.cbDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDil.Name = "cbDil";
            this.cbDil.Size = new System.Drawing.Size(249, 24);
            this.cbDil.TabIndex = 0;
            this.cbDil.SelectedIndexChanged += new System.EventHandler(this.cbDil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1119, 366);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ru/En/Vn v1.1";
            // 
            // linkvk
            // 
            this.linkvk.AutoSize = true;
            this.linkvk.LinkColor = System.Drawing.Color.Black;
            this.linkvk.Location = new System.Drawing.Point(1031, 66);
            this.linkvk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkvk.Name = "linkvk";
            this.linkvk.Size = new System.Drawing.Size(175, 16);
            this.linkvk.TabIndex = 29;
            this.linkvk.TabStop = true;
            this.linkvk.Text = "";
            this.linkvk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkvk_LinkClicked);
            // 
            // linkgszone
            // 
            this.linkgszone.AutoSize = true;
            this.linkgszone.LinkColor = System.Drawing.Color.Black;
            this.linkgszone.Location = new System.Drawing.Point(1031, 47);
            this.linkgszone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkgszone.Name = "linkgszone";
            this.linkgszone.Size = new System.Drawing.Size(175, 16);
            this.linkgszone.TabIndex = 30;
            this.linkgszone.TabStop = true;
            this.linkgszone.Text = "https://github.com/HaiHai-17";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 400);
            this.Controls.Add(this.linkgszone);
            this.Controls.Add(this.linkvk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDil);
            this.Controls.Add(this.btnEkleDil);
            this.Controls.Add(this.txtEkleXml);
            this.Controls.Add(this.txtEkleSwf);
            this.Controls.Add(this.btnEkleXml);
            this.Controls.Add(this.btnSilXml);
            this.Controls.Add(this.btnEkleSwf);
            this.Controls.Add(this.btnSilSwf);
            this.Controls.Add(this.lblUrlXml);
            this.Controls.Add(this.listXml);
            this.Controls.Add(this.lblUrlSwf);
            this.Controls.Add(this.listSwf);
            this.Controls.Add(this.lblUrlUi);
            this.Controls.Add(this.lblUrlFlash);
            this.Controls.Add(this.listDil);
            this.Controls.Add(this.btnIndir);
            this.Controls.Add(this.lblFlashDosyaAdi);
            this.Controls.Add(this.txtFlashDosyaAdi);
            this.Controls.Add(this.txtEkleDil);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.btnSilDil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.listFlash);
            this.Controls.Add(this.txtFlashDil);
            this.Controls.Add(this.txtFlashUrl);
            this.Controls.Add(this.lblFlashUrl);
            this.Controls.Add(this.lblFlashDil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1262, 447);
            this.MinimumSize = new System.Drawing.Size(1262, 447);
            this.Name = "Form1";
            this.Text = "DDTank Flash Downloader Ru/En/Vn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlashUrl;
        private System.Windows.Forms.TextBox txtFlashUrl;
        private System.Windows.Forms.Label lblFlashDil;
        private System.Windows.Forms.TextBox txtFlashDil;
        private System.Windows.Forms.ListBox listFlash;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.TextBox txtFlashDosyaAdi;
        private System.Windows.Forms.Label lblFlashDosyaAdi;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.ListBox listDil;
        private System.Windows.Forms.Label lblUrlFlash;
        private System.Windows.Forms.Label lblUrlUi;
        private System.Windows.Forms.ListBox listSwf;
        private System.Windows.Forms.Label lblUrlSwf;
        private System.Windows.Forms.ListBox listXml;
        private System.Windows.Forms.Label lblUrlXml;
        private System.Windows.Forms.Button btnSilDil;
        private System.Windows.Forms.TextBox txtEkleDil;
        private System.Windows.Forms.Button btnSilSwf;
        private System.Windows.Forms.Button btnEkleSwf;
        private System.Windows.Forms.TextBox txtEkleSwf;
        private System.Windows.Forms.Button btnSilXml;
        private System.Windows.Forms.Button btnEkleXml;
        private System.Windows.Forms.TextBox txtEkleXml;
        private System.Windows.Forms.Button btnEkleDil;
        private System.Windows.Forms.GroupBox gbDil;
        private System.Windows.Forms.ComboBox cbDil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkvk;
        private System.Windows.Forms.LinkLabel linkgszone;
    }
}

