using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> texts = new List<string>(new string[] { "Do greatest at in learning steepest. Breakfast extremity suffering one who all otherwise suspected. He at no nothing forbade up moments. Wholly uneasy at missed be of pretty whence. John way sir high than law who week. Surrounded prosperous introduced it if is up dispatched. Improved so strictly produced answered elegance is.", "For who thoroughly her boy estimating conviction. Removed demands expense account in outward tedious do.Particular way thoroughly unaffected projection favourable mrs can projecting own. Thirty it matter enable become admire in giving.See resolved goodness felicity shy civility domestic had but.Drawings offended yet answered jennings perceive laughing six did far. ", "On it differed repeated wandered required in. Then girl neat why yet knew rose spot.Moreover property we he kindness greatest be oh striking laughter.In me he at collecting affronting principles apartments.Has visitor law attacks pretend you calling own excited painted.Contented attending smallness it oh ye unwilling.Turned favour man two but lovers.Suffer should if waited common person little oh. Improved civility graceful sex few smallest screened settling. Likely active her warmly has.", "Breakfast procuring nay end happiness allowance assurance frankness. Met simplicity nor difficulty unreserved who. Entreaties mr conviction dissimilar me astonished estimating cultivated. On no applauded exquisite my additions. Pronounce add boy estimable nay suspected. You sudden nay elinor thirty esteem temper.Quiet leave shy you gay off asked large style.", "Old there any widow law rooms. Agreed but expect repair she nay sir silent person.Direction can dependent one bed situation attempted.His she are man their spite avoid.Her pretended fulfilled extremely education yet. Satisfied did one admitting incommode tolerably how are.", "Smallest directly families surprise honoured am an.Speaking replying mistress him numerous she returned feelings may day. Evening way luckily son exposed get general greatly. Zealously prevailed be arranging do.Set arranging too dejection september happiness. Understood instrument or do connection no appearance do invitation.Dried quick round it or order.Add past see west felt did any.Say out noise you taste merry plate you share.My resolve arrived is we chamber be removal.", "Yourself off its pleasant ecstatic now law.Ye their mirth seems of songs. Prospect out bed contempt separate.Her inquietude our shy yet sentiments collecting.Cottage fat beloved himself arrived old. Grave widow hours among him no you led. Power had these met least nor young.Yet match drift wrong his our.", "In reasonable compliment favourable is connection dispatched in terminated.Do esteem object we called father excuse remove. So dear real on like more it.Laughing for two families addition expenses surprise the.If sincerity he to curiosity arranging.Learn taken terms be as. Scarcely mrs produced too removing new old.", "Considered an invitation do introduced sufficient understood instrument it. Of decisively friendship in as collecting at.No affixed be husband ye females brother garrets proceed.Least child who seven happy yet balls young. Discovery sweetness principle discourse shameless bed one excellent. Sentiments of surrounded friendship dispatched connection is he.Me or produce besides hastily up as pleased.Bore less when had and john shed hope.", "As absolute is by amounted repeated entirely ye returned. These ready timed enjoy might sir yet one since.Years drift never if could forty being no.On estimable dependent as suffering on my. Rank it long have sure in room what as he.Possession travelling sufficient yet our. Talked vanity looked in to. Gay perceive led believed endeavor.Rapturous no of estimable oh therefore direction up. Sons the ever not fine like eyes all sure." });

            Random rnd = new Random();
            int random = rnd.Next(1, texts.Count());
            TextToType.Text = texts[random];
            


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            testbox.Text = TextToType.Text.Substring(0,typingText.TextLength);
            if (typingText.Text == (TextToType.Text.Substring(0, typingText.TextLength)))
            {
                //progressBar.Value = 50;
                progressBar.Value = (int)(((double)typingText.TextLength / TextToType.Text.Length) * 100);
                //progressBar.Value = Convert.ToInt32((350d/500) * 100);
                status.Text = "Correct" + ((typingText.TextLength ) + " " +  (TextToType.Text.Length));
            }
            else
            {
                 status.Text = "ERROR MADE!!!";
            }
        }
    }
}
