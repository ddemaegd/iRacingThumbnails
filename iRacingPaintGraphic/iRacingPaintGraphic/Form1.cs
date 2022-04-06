using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iRacingSDK;

namespace iRacingPaintGraphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Dictionary<String, string> carList = new Dictionary<string, string>();


            //TODO Add Legends and IR04 car

            carList.Add("ARCA Menards Chevrolet Impala", "stockcars2 chevy");
            carList.Add("Aston Martin DBR9 GT1", "astonmartin dbr9");
            carList.Add("Audi 90 GTO", "audi90gto");
            carList.Add("Audi R18", "audir18");
            carList.Add("Audi R8 LMS", "audir8gt3");
            carList.Add("Audi RS 3 LMS", "audirs3lms");
            carList.Add("BMW M4 GT3 - Prototype", "bmwm4gt3");
            carList.Add("BMW M4 GT4", "bmwm4gt4");
            carList.Add("BMW M8 GTE", "bmwm8gte");
            carList.Add("BMW Z4 GT3", "bmwz4gt3");
            carList.Add("Cadillac CTS-V Racecar", "cadillacctsvr");
            carList.Add("Chevrolet Corvette C6R GT1", "c6r");
            carList.Add("Chevrolet Corvette C7 Daytona Prototype", "c7vettedp");
            carList.Add("Chevrolet Corvette C8.R GTE", "c8rvettegte");
            carList.Add("Chevrolet Monte Carlo SS", "latemodel");
            carList.Add("Dallara F3", "dallaraf3");
            carList.Add("Dallara IR01", "dallarair01");
            carList.Add("Dallara IR18", "dallarair18");
            carList.Add("Dallara P217", "dallarap217");
            carList.Add("Dirt Late Models 350", "dirtlatemodel 350");
            carList.Add("Dirt Late Models 358", "dirtlatemodel 358");
            carList.Add("Dirt Late Models 438", "dirtlatemodel 438");
            carList.Add("Dirt Legends Ford 34 Coupe", "legends dirtford34c");
            carList.Add("Dirt Midget", "dirtmidget");
            carList.Add("Dirt Modifieds 358", "dirtmodified 358");
            carList.Add("Dirt Modifieds BigBlock", "dirtmodified bigblock");
            carList.Add("Dirt Sprint Cars Winged 305", "dirtsprint winged 305");
            carList.Add("Dirt Sprint Cars Winged 360", "dirtsprint winged 360");
            carList.Add("Dirt Sprint Cars Winged 410", "dirtsprint winged 410");
            carList.Add("Dirt Sprint Cars - Non-Winged 360", "dirtsprint nonwinged 360");
            carList.Add("Dirt Sprint Cars - Non-Winged 410", "dirtsprint nonwinged 410");
            carList.Add("Dirt Street Stock", "dirtstreetstock");
            carList.Add("Dirt UMP Modified", "dirtumpmod");
            carList.Add("Ferrari 488 GT3", "ferrari488gt3");
            carList.Add("Ferrari 488 GTE", "ferrari488gte");
            carList.Add("Ford Fiesta RS WRC", "fordfiestarswrc");
            carList.Add("Ford GT", "fordgt");
            carList.Add("Ford GT - 2017", "fordgt2017");
            carList.Add("Ford GT3", "fordgt gt3");
            carList.Add("Ford Mustang FR500S", "fr500s");
            carList.Add("Formula Renault 2.0", "formularenault20");
            carList.Add("Formula Renault 3.5", "formularenault35");
            carList.Add("Formula Vee", "formulavee");
            carList.Add("Global Mazda MX-5 Cup", "mx5 mx52016");
            carList.Add("HPD ARX-01a", "hpdarx01c");
            carList.Add("Indy Pro 2000 PM-18", "indypropm18");
            carList.Add("Kia Optima", "kiaoptima");
            carList.Add("Lamborghini GT3 (placeholder)", "lamborghinievogt3");
            carList.Add("Legends Ford 34 Coupe", "legends ford34c");
            carList.Add("Legends Ford 34 Coupe - Rookie", "legends ford34c rookie");
            carList.Add("Lotus 49", "lotus49");
            carList.Add("Lotus 79", "lotus79");
            carList.Add("Lucas Oil Off Road Pro 2 Lite", "protrucks pro2lite");
            carList.Add("Lucas Oil Off Road Pro 2 Truck", "protrucks pro2truck");
            carList.Add("Lucas Oil Off Road Pro 4 Truck", "protrucks pro4truck");
            carList.Add("McLaren 570s GT4", "mclaren570sgt4");
            carList.Add("McLaren MP4-12C GT3", "mclarenmp4");
            carList.Add("McLaren MP4-30", "mclarenmp430");
            carList.Add("Mercedes AMG GT3", "mercedesamggt3");
            carList.Add("Modifieds", "skmodified");
            carList.Add("Modifieds Tour", "skmodified tour");
            carList.Add("NASCAR Chevrolet Monte Carlo - 1987", "stockcars chevymontecarlo87");
            carList.Add("NASCAR Cup Series Chevrolet Camaro ZL1", "stockcars camarozl12018");
            carList.Add("NASCAR Cup Series Ford Mustang", "stockcars fordmustang2019");
            carList.Add("NASCAR Cup Series Toyota Camry", "stockcars toyotacamry");
            carList.Add("NASCAR Ford Thunderbird - 1987", "stockcars fordthunderbird87");
            carList.Add("NASCAR Gander Outdoors Chevrolet Silverado", "trucks silverado2019");
            carList.Add("NASCAR Gander Outdoors Ford F150", "trucks fordf150");
            carList.Add("NASCAR Gander Outdoors Toyota Tundra", "trucks tundra2015");
            carList.Add("NASCAR XFINITY Chevrolet Camaro", "stockcars2 camaro2019");
            carList.Add("NASCAR XFINITY Ford Mustang", "stockcars2 mustang2019");
            carList.Add("NASCAR XFINITY Toyota Supra", "stockcars2 supra2019");
            carList.Add("Nissan GTP ZX-T", "nissangtpzxt");
            carList.Add("Pontiac Solstice", "solstice");
            carList.Add("Pontiac Solstice - Rookie", "solstice rookie");
            carList.Add("Porsche 718 Cayman GT4 Clubsport MR", "porsche718gt4");
            carList.Add("Porsche 911 GT3 Cup (991)", "porsche911cup");
            carList.Add("Porsche 911 RSR", "porsche991rsr");
            carList.Add("Porsche 919", "porsche919");
            carList.Add("Radical SR8", "radical sr8");
            carList.Add("Ruf RT 12R AWD", "rufrt12r awd");
            carList.Add("Ruf RT 12R C-Spec", "rufrt12r track cspec");
            carList.Add("Ruf RT 12R RWD", "rufrt12r rwd");
            carList.Add("Ruf RT 12R Track", "rufrt12r track");
            carList.Add("SCCA Spec Racer Ford", "specracer");
            carList.Add("Silver Crown", "silvercrown");
            carList.Add("Skip Barber Formula 2000", "rt2000");
            carList.Add("Sprint Car", "sprint");
            carList.Add("Street Stock", "streetstock");
            carList.Add("Subaru WRX STI", "subaruwrxsti");
            carList.Add("Super Late Model", "superlatemodel");
            carList.Add("Supercars Ford Mustang GT", "v8supercars fordmustanggt");
            carList.Add("Supercars Holden ZB Commodore", "v8supercars holden2019");
            carList.Add("USF 2000", "usf2000usf17");
            carList.Add("Volkswagen Jetta TDI Cup", "jettatdi");
            carList.Add("VW Beetle GRC", "vwbeetlegrc");
            carList.Add("[Legacy] Dallara DW12", "dallaradw12");
            carList.Add("[Legacy] Indycar Dallara - 2009", "dallara");
            carList.Add("[Legacy] Mazda MX-5 Cup - 2010", "mx5 cup");
            carList.Add("[Legacy] Mazda MX-5 Roadster - 2010", "mx5 roadster");
            carList.Add("[Legacy] NASCAR Cup Chevrolet Impala COT - 2009", "stockcars impala");
            carList.Add("[Legacy] NASCAR Cup Chevrolet SS - 2013", "stockcars chevyss");
            carList.Add("[Legacy] NASCAR Cup Ford Fusion - 2016", "stockcars fordfusion");
            carList.Add("[Legacy] NASCAR Nationwide Chevrolet Impala - 2012", "stockcars2 chevy cot");
            carList.Add("[Legacy] NASCAR Truck Chevrolet Silverado - 2008", "trucks silverado");
            carList.Add("[Legacy] NASCAR Xfinity Chevrolet Camaro - 2014", "stockcars2 nwcamaro2014");
            carList.Add("[Legacy] NASCAR Xfinity Ford Mustang - 2016", "stockcars2 nwford2013");
            carList.Add("[Legacy] NASCAR Xfinity Toyota Camry - 2015", "stockcars2 camry2015");
            carList.Add("[Legacy] Pro Mazda", "formulamazda");
            carList.Add("[Legacy] Riley MkXX Daytona Prototype - 2008", "rileydp");
            carList.Add("[Legacy] V8 Supercar Ford Falcon - 2009", "fordv8sc");
            carList.Add("[Legacy] V8 Supercar Ford FG Falcon - 2014", "v8supercars ford2014");
            carList.Add("[Legacy] V8 Supercar Holden VF Commodore - 2014", "v8supercars holden2014");


            CarDropDown.DataSource = new BindingSource(carList, null);
            CarDropDown.DisplayMember = "Key";
            CarDropDown.ValueMember = "Value";

            //default links for me
            //TODO: save this in a config file if ever planning to release
            PaintFileTextBox.Text = @"C:\Users\ddema\Documents\iRacing\paint";
            SaveFileTextBox.Text = @"C:\Users\ddema\Pictures\iRacingGraphics\SpotterGuides";


        }

        private static void VerifyDataStream()
        {
            var lastTickCount = 0;
            var lastFrame = 0;

            var firstData = iRacing.GetDataFeed().First();
            var offset = firstData.Telemetry.SessionTime - (float)firstData.Telemetry.ReplayFrameNum / 60f;

            foreach (var data in iRacing.GetDataFeed())
            {
                if (data.Telemetry.TickCount != lastTickCount + 1)
                {
                    Console.WriteLine("Tick count glitch {0}, {1}", lastTickCount, data.Telemetry.TickCount);
                }

                if (data.Telemetry.ReplayFrameNum != lastFrame + 1)
                {
                    Console.WriteLine("Frame number count glitch {0}, {1}", lastFrame, data.Telemetry.ReplayFrameNum);
                }

                var newTimeDelta = (int)((float)data.Telemetry.ReplayFrameNum / 60f + offset - data.Telemetry.SessionTime) * 1000;

                if (newTimeDelta != 0)
                    Console.WriteLine("Frame time {0}", newTimeDelta);

                Thread.Sleep(13);
                lastTickCount = data.Telemetry.TickCount;
                lastFrame = data.Telemetry.ReplayFrameNum;
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "Running...";
                Random random = new Random();

                string filepath = PaintFileTextBox.Text + @"\" + CarDropDown.SelectedValue;
                DirectoryInfo d = new DirectoryInfo(filepath);

                string saveLocation = SaveFileTextBox.Text + @"\" + CarDropDown.SelectedItem + @"\" + random.Next(1, 1000) + @"\";

                //iRacing SDK connects to game
                var iracing = new iRacingConnection();
                var data = iracing.GetDataFeed().First();

                var ieventRacing = new iRacingEvents();
                ieventRacing.StartListening();

                List<UserDriverObject> userDriverObjects = new List<UserDriverObject>();

                foreach (SessionData._DriverInfo._Drivers car in data.SessionData.DriverInfo.CompetingDrivers)
                {
                    UserDriverObject userDriverObject = new UserDriverObject();
                    //dont include pace car
                    if (car.UserID == -1)
                    {
                        continue;
                    }
    
                    userDriverObject.ID = car.UserID.ToString();
                    userDriverObject.Name = car.UserName;
                    userDriverObject.Number = car.CarNumber;
                    userDriverObject.File = "car_" + car.UserID.ToString() + ".tga";

                    //set rim color if specified
                    if (car.CarDesignStr.Split(";").Count() > 1)
                    {
                        userDriverObject.RimColor = car.CarDesignStr.Split(";")[1];
                    }
                    else
                    {
                        userDriverObject.RimColor = "000000";
                    }
                    userDriverObject.NumberColor1 = car.CarNumberDesignStr.Split(",")[2] + "," + car.CarNumberDesignStr.Split(",")[3] + "," + car.CarNumberDesignStr.Split(",")[4];
                    userDriverObject.NumberColor2 = car.CarNumberDesignStr.Split(",")[0];
                    
                    userDriverObjects.Add(userDriverObject);
                }

                //Order By Car Number
                userDriverObjects = userDriverObjects.OrderBy(x => x.Number).ToList();

                //get paint files from local directory
                foreach (FileInfo file in d.GetFiles("*.tga"))
                {

                    string imageUrl = "";
                    string savename = "";
                    if (userDriverObjects.Where(x => x.File == file.Name.Replace("num_","")).ToList().Count > 0)
                    {
                        //check for custom number paint
                        //use iRacing provided thumbnails
                        if (file.Name.Contains("num"))
                        {
                            imageUrl = @"http://localhost:32034/pk_car.png?size=2&view=1&carPath=" + CarDropDown.SelectedValue.ToString().Replace(" ", @"\") + "&carRimCol=" + userDriverObjects.Where(x => x.File == file.Name.Replace("num_", "")).FirstOrDefault().RimColor + "&carCustPaint=" + PaintFileTextBox.Text + @"\" + CarDropDown.SelectedValue + @"\" + file.Name;
                            savename = userDriverObjects.Where(x => x.File == file.Name.Replace("num_", "")).FirstOrDefault().Number + "_" + userDriverObjects.Where(x => x.File == file.Name.Replace("num_", "")).FirstOrDefault().Name;
                        }
                        else
                        {
                            imageUrl = @"http://localhost:32034/pk_car.png?size=2&view=1&carPath=" + CarDropDown.SelectedValue.ToString().Replace(" ", @"\") + "&number=" + userDriverObjects.Where(x => x.File == file.Name).FirstOrDefault().Number + "&carRimCol=" + userDriverObjects.Where(x => x.File == file.Name).FirstOrDefault().RimColor + "&numCol=" + userDriverObjects.Where(x => x.File == file.Name).FirstOrDefault().NumberColor1 + "&numPat=" + userDriverObjects.Where(x => x.File == file.Name).FirstOrDefault().NumberColor2 + "&carCustPaint=" + PaintFileTextBox.Text + @"\" + CarDropDown.SelectedValue + @"\" + file.Name;
                            savename = userDriverObjects.Where(x => x.File == file.Name).FirstOrDefault().Number + "_" + userDriverObjects.Where(x => x.File == file.Name).FirstOrDefault().Name;
                        }
                        
                    }
                    else
                    {
                        imageUrl = @"http://localhost:32034/pk_car.png?size=2&view=1&carPath=" + CarDropDown.SelectedValue.ToString().Replace(" ", @"\") + "&number=1&numCol=FFFFFF,000000,000000&carCustPaint=" + PaintFileTextBox.Text + @"\" + CarDropDown.SelectedValue + @"\" + file.Name;
                        savename = file.Name.Replace(file.Extension, "");
                    }

                    //write image
                    byte[] imageBytes;
                    HttpWebRequest imageRequest = (HttpWebRequest)WebRequest.Create(imageUrl);
                    WebResponse imageResponse = imageRequest.GetResponse();

                    Stream responseStream = imageResponse.GetResponseStream();

                    using (BinaryReader br = new BinaryReader(responseStream))
                    {
                        imageBytes = br.ReadBytes(500000);
                        br.Close();
                    }
                    responseStream.Close();
                    imageResponse.Close();


                    System.IO.Directory.CreateDirectory(saveLocation);


                    FileStream fs = new FileStream(saveLocation + savename + ".png", FileMode.Create);
                    BinaryWriter bw = new BinaryWriter(fs);
                    try
                    {
                        bw.Write(imageBytes);
                    }
                    finally
                    {
                        fs.Close();
                        bw.Close();
                    }
                }


                //merge files into 1 spotter guide
                if (chkMerge.Checked)
                {
                    // Get the picture files in the source directory.
                    List<FileInfo> files = new List<FileInfo>();
                    foreach (string filename in Directory.GetFiles(saveLocation))
                    {
                        int pos = filename.LastIndexOf('.');
                        string extension = filename.Substring(pos).ToLower();
                        if ((extension == ".bmp") ||
                            (extension == ".jpg") ||
                            (extension == ".jpeg") ||
                            (extension == ".png") ||
                            (extension == ".tif") ||
                            (extension == ".tiff") ||
                            (extension == ".gif"))
                            files.Add(new FileInfo(filename));
                    }
                    files = files.Select(s => new { Str = s, Split = s.Name.Split('_') })
                            .OrderBy(x => int.Parse(x.Split[0]))
                            .ThenBy(x => x.Split[1])
                            .Select(x => x.Str)
                            .ToList();
                    int num_images = files.Count;

                    // Load the images.
                    Bitmap[] images = new Bitmap[files.Count];
                    String[] imageName = new String[files.Count];
                    for (int i = 0; i < num_images; i++)
                    {
                        images[i] = new Bitmap(files[i].FullName);
                        imageName[i] = new String(files[i].Name);
                    }

                    // Find the largest width and height.
                    int max_wid = 0;
                    int max_hgt = 0;
                    for (int i = 0; i < num_images; i++)
                    {
                        if (max_wid < images[i].Width) max_wid = images[i].Width;
                        if (max_hgt < images[i].Height) max_hgt = images[i].Height;
                    }

                    // Make the result bitmap.
                    int marginX = 100;
                    int marginY = 100;
                    int num_cols = int.Parse(txtColumns.Text);
                    int num_rows = (int)Math.Ceiling(num_images / (float)num_cols);
                    //increment rows for extra space
                    num_rows++;
                    int wid = max_wid * num_cols + marginX * (num_cols - 1);
                    int hgt = max_hgt * num_rows + marginY * (num_rows - 1);
                    Bitmap bm = new Bitmap(wid, hgt);

                    // Place the images on it.
                    using (Graphics gr = Graphics.FromImage(bm))
                    {
                        gr.Clear(Color.Transparent);

                        //pic is 508x272

                        int x = 0;
                        int y = marginY;
                        for (int i = 0; i < num_images; i++)
                        {
                            gr.DrawImage(images[i], x, y);
                            using (Font arialFont = new Font("RussellSquare", 30))
                            {
                                string value = "#" + imageName[i].Split("_")[0] + " " + imageName[i].Split("_")[1].Replace(".png", "");
                                gr.DrawString(value, arialFont, Brushes.White, new Point((int)(x + (max_wid - gr.MeasureString(value, arialFont).Width) / 2f), y + max_hgt));
                            }
                            x += max_wid + marginX;
                            if (x >= wid)
                            {
                                y += max_hgt + marginY;
                                x = 0;
                            }
                        }
                    }

                    // Save the result.
                    bm.Save(saveLocation + "MergedImage.png", System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            lblMessage.Text = "Done!";
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        
        private void PaintFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = this.folderBrowserDialog1;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                PaintFileTextBox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = this.folderBrowserDialog2;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                SaveFileTextBox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void chkMerge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {

        }
    }
}
