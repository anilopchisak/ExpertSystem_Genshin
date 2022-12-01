using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ExpertSystem_Genshin
{
    public partial class Form1 : Form
    {
        int i = 0; int j = 0; // number of the character, of the property
        private string answ = "";
        List<Property> data = new List<Property>();

        // List of properties 
        static Property enigmatic = new Property("Are you enigmatic?", "yes");
        static Property not_enigmatic = new Property("Are you enigmatic?", "no");

        static Property eccentric = new Property("Are you eccentric?", "yes");
        static Property not_eccentric = new Property("Are you eccentric?", "no");

        static Property dramatic = new Property("Are you dramatic?", "yes");
        static Property not_dramatic = new Property("Are you dramatic?", "no");

        static Property old = new Property("Are you old?", "yes");
        static Property not_old = new Property("Are you old?", "no");

        static Property handyman = new Property("Are you a handyman?", "yes");
        static Property not_handyman = new Property("Are you a handyman?", "no");

        static Property erudite = new Property("Are you erudite?", "yes");
        static Property not_erudite = new Property("Are you erudite?", "no");

        static Property nature_lover = new Property("Are you a nature lover?", "yes");
        static Property not_nature_lover = new Property("Are you a nature lover?", "no");

        static Property astrology = new Property("Do you believe in astrology?", "yes");
        static Property not_astrology = new Property("Do you believe in astrology?", "no");

        static Property elegant = new Property("Are you elegant?", "yes");
        static Property not_elegant = new Property("Are you elegant?", "no");

        static Property lazy = new Property("Are you lazy?", "yes");
        static Property not_lazy = new Property("Are you lazy?", "no");

        static Property selfish = new Property("Are you selfish?", "yes");
        static Property not_selfish = new Property("Are you selfish?", "no");

        static Property frightenting = new Property("Are you frightenting?", "yes");
        static Property not_frightenting = new Property("Are you frightenting?", "no");

        static Property daring = new Property("Are you daring?", "yes");
        static Property not_daring = new Property("Are you daring?", "no");

        static Property laws = new Property("Do you follow the laws?", "yes");
        static Property not_laws = new Property("Do you follow the laws?", "no");

        static Property lonely = new Property("Are you lonely?", "yes");
        static Property not_lonely = new Property("Are you lonely?", "no");

        static Property superhero = new Property("Would you like to be a superhero?", "yes");
        static Property not_superhero = new Property("Would you like to be a superhero?", "no");

        static Property hardworking = new Property("Are you hardworking?", "yes");
        static Property not_hardworking = new Property("Are you hardworking?", "no");

        static Property sporty = new Property("Are you sporty?", "yes");
        static Property not_sporty = new Property("Are you sporty?", "no");

        static Property science = new Property("Do you like science?", "yes");
        static Property not_science = new Property("Do you like science?", "no");

        static Property serious = new Property("Are you serious?", "yes");
        static Property not_serious = new Property("Are you serious?", "no");

        static Property sacrificial = new Property("Are you sacrificial?", "yes");
        static Property not_sacrificial = new Property("Are you sacrificial?", "no");

        static Property merciful = new Property("Are you merciful?", "yes");
        static Property not_merciful = new Property("Are you merciful?", "no");

        static Property resolute = new Property("Are you resolute?", "yes");
        static Property not_resolute = new Property("Are you resolute?", "no");

        static Property resourceful = new Property("Are you resourceful?", "yes");
        static Property not_resourceful = new Property("Are you resourceful?", "no");

        static Property smart = new Property("Are you smart?", "yes");
        static Property not_smart = new Property("Are you smart?", "no");

        static Property wine = new Property("Do you like wine?", "yes");
        static Property not_wine = new Property("Do you like wine?", "no");

        static Property cooking = new Property("Do you like cooking?", "yes");
        static Property not_cooking = new Property("Do you like cooking?", "no");

        static Property looser = new Property("Are you a looser?", "yes");
        static Property not_looser = new Property("Are you a looser?", "no");

        //List<Property> props = new List<Property>() { enigmatic, eccentric, dramatic, old, handyman, erudite, nature_lover, astrology, elegant,
        //                                             lazy, selfish, frightenting, daring, laws, lonely, superhero };

        // List of Characters
        static Result res_fischl = new Result("Fischl");
        static Character char_fischl = new Character(res_fischl, new List<Property> { enigmatic, eccentric, dramatic }, "fischl.jpg");

        static Result res_dainsleif = new Result("Dainsleif");
        static Character char_dainsleif = new Character(res_dainsleif, new List<Property> { enigmatic, eccentric, not_dramatic, old }, "dainsleif.jpg");

        static Result res_kuki = new Result("Kuki Shinobu");
        static Character char_kuki = new Character(res_kuki, new List<Property> { enigmatic, eccentric, not_dramatic, not_old, handyman }, "kuki.jpg");

        static Result res_faruzan = new Result("Faruzan");
        static Character char_faruzan = new Character(res_faruzan, new List<Property> { enigmatic, eccentric, not_dramatic, not_old, not_handyman, erudite }, "faruzan.jpg");

        static Result res_razor = new Result("Razor");
        static Character char_razor = new Character(res_razor, new List<Property> { enigmatic, eccentric, not_dramatic, not_old, not_handyman, not_erudite, nature_lover }, "razor.jpg");

        static Result res_mona = new Result("Mona");
        static Character char_mona = new Character(res_mona, new List<Property> { enigmatic, eccentric, not_dramatic, not_old, not_handyman, not_erudite, not_nature_lover, astrology }, "mona.jpg");

        static Result res_eula = new Result("Eula");
        static Character char_eula = new Character(res_eula, new List<Property> { enigmatic, eccentric, not_dramatic, not_old, not_handyman, not_erudite, not_nature_lover, not_astrology }, "eula.jpg");

        static Result res_lisa = new Result("Lisa");
        static Character char_lisa = new Character(res_lisa, new List<Property> { enigmatic, not_eccentric, elegant, lazy }, "lisa.jpg");

        static Result res_yemiko = new Result("Ye Miko");
        static Character char_yemiko = new Character(res_yemiko, new List<Property> { enigmatic, not_eccentric, elegant, not_lazy, selfish }, "ye.jpg");

        static Result res_raiden = new Result("Raiden Shogun");
        static Character char_raiden = new Character(res_raiden, new List<Property> { enigmatic, not_eccentric, elegant, not_lazy, not_selfish, frightenting }, "raiden.jpg");

        static Result res_shenhe = new Result("Shen He");
        static Character char_shenhe = new Character(res_shenhe, new List<Property> { enigmatic, not_eccentric, elegant, not_lazy, not_selfish, not_frightenting, daring }, "shen.jpg");

        static Result res_ningguang = new Result("Ning Guang");
        static Character char_ningguang = new Character(res_ningguang, new List<Property> { enigmatic, not_eccentric, elegant, not_lazy, not_selfish, not_frightenting, not_daring, laws }, "ningguang.jpg");

        static Result res_baydoe = new Result("Bay Doe");
        static Character char_baydoe = new Character(res_baydoe, new List<Property> { enigmatic, not_eccentric, elegant, not_lazy, not_selfish, not_frightenting, not_daring, not_laws }, "baydoe.jpg");

        static Result res_stranger = new Result("Stranger");
        static Character char_stranger = new Character(res_stranger, new List<Property> { enigmatic, not_eccentric, not_elegant, frightenting }, "wanderer.jpg");

        static Result res_xiao = new Result("Xiao");
        static Character char_xiao = new Character(res_xiao, new List<Property> { enigmatic, not_eccentric, not_elegant, not_frightenting, lonely }, "xiao.jpg");

        static Result res_diluk = new Result("Diluk");
        static Character char_diluk = new Character(res_diluk, new List<Property> { enigmatic, not_eccentric, not_elegant, not_frightenting, not_lonely, superhero }, "diluk.jpg");

        static Result res_albedo = new Result("Albedo");
        static Character char_albedo = new Character(res_albedo, new List<Property> { enigmatic, not_eccentric, not_elegant, not_frightenting, not_lonely, not_superhero }, "albedo.jpg");

        static Result res_noelle = new Result("Noelle");
        static Character char_noelle = new Character(res_noelle, new List<Property> { not_enigmatic, hardworking, sporty }, "noelle.jpg");

        static Result res_sucrose = new Result("Sucrose");
        static Character char_sucrose = new Character(res_sucrose, new List<Property> { not_enigmatic, hardworking, not_sporty, science }, "sucrose.jpg");
        
        static Result res_keqing = new Result("Keqing");
        static Character char_keqing = new Character(res_keqing, new List<Property> { not_enigmatic, hardworking, not_sporty, not_science, serious }, "keqing.jpg");

        static Result res_kokomi = new Result("Kokomi");
        static Character char_kokomi = new Character(res_kokomi, new List<Property> { not_enigmatic, hardworking, not_sporty, not_science, not_serious, sacrificial }, "kokomi.jpg");

        static Result res_tignari = new Result("Tignari");
        static Character char_tignari = new Character(res_tignari, new List<Property> { not_enigmatic, hardworking, not_sporty, not_science, not_serious, not_sacrificial, merciful }, "tignari.jpg");

        static Result res_ayaka = new Result("Ayaka");
        static Character char_ayaka = new Character(res_ayaka, new List<Property> { not_enigmatic, hardworking, not_sporty, not_science, not_serious, not_sacrificial, not_merciful, resolute }, "ayaka.jpg");

        static Result res_ayato = new Result("Ayato");
        static Character char_ayato = new Character(res_ayato, new List<Property> { not_enigmatic, hardworking, not_sporty, not_science, not_serious, not_sacrificial, not_merciful, not_resolute, resourceful }, "ayato.jpg");

        static Result res_ganyu = new Result("Gan Yu");
        static Character char_ganyu = new Character(res_ganyu, new List<Property> { not_enigmatic, hardworking, not_sporty, not_science, not_serious, not_sacrificial, not_merciful, not_resolute, not_resourceful }, "ganyu.jpg");

        static Result res_sinqiu = new Result("Sin Qiu");
        static Character char_sinqiu = new Character(res_sinqiu, new List<Property> { not_enigmatic, not_hardworking, erudite }, "sinqiu.jpg");

        static Result res_tartaglia = new Result("Tartaglia");
        static Character char_tartaglia = new Character(res_tartaglia, new List<Property> { not_enigmatic, not_hardworking, not_erudite, not_laws, smart }, "tartaglia.jpg");

        static Result res_aratakiitto = new Result("Arataki Itto");
        static Character char_aratakiitto = new Character(res_aratakiitto, new List<Property> { not_enigmatic, not_hardworking, not_erudite, not_laws, not_smart }, "itto.jpg");

        static Result res_venti = new Result("Venti");
        static Character char_venti = new Character(res_venti, new List<Property> { not_enigmatic, not_hardworking, not_erudite, wine }, "venti.jpg");

        static Result res_xianglin = new Result("Xiang Lin");
        static Character char_xianglin = new Character(res_xianglin, new List<Property> { not_enigmatic, not_hardworking, not_erudite, not_wine, cooking }, "xianglin.jpg");

        static Result res_bennett = new Result("Bennett");
        static Character char_bennett = new Character(res_bennett, new List<Property> { not_enigmatic, not_hardworking, not_erudite, not_wine, not_cooking, looser }, "bennett.jpg");

        static Result res_qiqi = new Result("Qiqi");
        static Character char_qiqi = new Character(res_qiqi, new List<Property> { not_enigmatic, not_hardworking, not_erudite, not_wine, not_cooking, not_looser }, "qiqi.jpg");

        List<Character> chars = new List<Character>() { char_fischl, char_dainsleif, char_kuki, char_faruzan, char_razor, char_mona, char_eula, 
                                                        char_lisa, char_yemiko, char_raiden, char_shenhe, char_ningguang, char_baydoe, char_stranger,
                                                        char_xiao, char_diluk, char_albedo, char_noelle, char_sucrose, char_keqing, char_kokomi,
                                                        char_tignari, char_ayaka, char_ayato, char_ganyu, char_sinqiu, char_tartaglia, char_aratakiitto,
                                                        char_venti, char_xianglin, char_bennett, char_qiqi };

        public Form1()
        {
            InitializeComponent();
            label_q.SelectionAlignment = HorizontalAlignment.Center;
            label_q.Text = "Who are you in Genshin Impact?";
            data.Clear();
            btn_yes.Visible = false;
            btn_no.Visible = false;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            answ = "yes";
            check_answ();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            answ = "no";
            check_answ();
        }

        private void test()
        { 
            if (data.Count == 0) 
            {
                label_q.Text = chars[i].props[j].q;
            }
            else
            {
                while (true)
                {
                    // переход на текущее свойство
                    while (j < data.Count && chars[i].props[j].q == data[j].q && chars[i].props[j].answ == data[j].answ)
                        j++;

                    if (j < data.Count)
                    {
                        j = 0; i++;
                    }
                    else if (j == data.Count && j < chars[i].props.Count)
                    {
                        label_q.Text = chars[i].props[j].q;
                        break;
                    }
                    else
                    {
                        show_result();
                        break;
                    }
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "Start")
            {
                btn_start.Text = "Restart";
                btn_yes.Visible = true;
                btn_no.Visible = true;
                i = 0; j = 0;
                test();
            }
            else
            {
                btn_start.Text = "Start";
                label_q.Text = "Who are you in Genshin Impact?";
                pictureBox1.Image = null;
                pictureBox1.Visible = false;
                btn_yes.Visible = false;
                btn_no.Visible = false;
                data.Clear();
            }
        }

        private void show_result()
        {
            btn_yes.Visible = false;
            btn_no.Visible = false;
            pictureBox1.Size = Image.FromFile("C:\\Archive\\Study\\Учеба\\ИЗ\\лр34\\ExpertSystem_Genshin\\Resources\\" + chars[i].pic).Size;
            pictureBox1.Image = Image.FromFile("C:\\Archive\\Study\\Учеба\\ИЗ\\лр34\\ExpertSystem_Genshin\\Resources\\" + chars[i].pic);
            pictureBox1.Visible = true;
            label_q.Text = "You are " + chars[i].res.charact + "!";
        }

        private void check_answ()
        {
            if (chars[i].props[j].answ == answ)
            {
                data.Add(chars[i].props[j]);
                j++;
            }
            else
            {
                Property prop = new Property(chars[i].props[j].q, chars[i].props[j].answ);
                prop.answ = answ;
                data.Add(prop);
                j = 0; 
            }
            test();
        }
    }
}
