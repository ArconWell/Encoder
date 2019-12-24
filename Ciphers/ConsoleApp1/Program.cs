using Ciphers;
using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            CaesarCipher cipher = new CaesarCipher();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(cipher.Encrypt("АбВгдеЁжЗюЯё", 4, "Cyrillic"));
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine(ts);
            sw.Restart();
            Console.WriteLine(cipher.Encrypt("AbCdefGhIjKl", 4, "Latin"));
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine(ts);
            sw.Restart();
            Console.WriteLine(cipher.Decrypt("ДеЖзийЁкЛвГё", 4, "Cyrillic"));
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine(ts);
            sw.Restart();
            Console.WriteLine(cipher.Decrypt("EfGhijKlMnOp", 4, "Latin"));
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine(ts);
            sw.Restart();
            Console.WriteLine(cipher.Hack("Alex qeoiw izivc Eqivmger e xctmgep sri mw e hiwmvi xs kix e aipp-temh nsf xlex ampp gsziv xlimv gvihmx gevh. E gvihmx gevh mw er mrhmwtirwefpi tevx sj pmji mr Eqivmge. Mr sxliv asvhw, erc Eqivmger orsaw xlex lsa li sv wli lerhpiw xlimv gvihmx gevh sv gevhw, imxliv ampp lipt xliq sv leyrx xliq jsv cievw.Mr xli Y.W.kixxmrk e gevh mwr’x ew levh ew mx ywih xs fi.Wsqi gsqtermiw rsa qemp ettpmgexmsrw xs lmkl wglssp wxyhirxw, vexliv xler aemxmrk jsv xliq xs kix mrxs gsppiki.Ex xlimv fiwx gvihmx gevhw eppsa xlimv sarivw xs viwivzi lsxip vssqw, virx gevw erh jmrergi pevkiv tyvglewiw sziv wizivep qsrxlw.Ex xlimv asvwx, gevhw eppsa tistpi amxl tssv qsric qerekiqirx womppw xs kix mrxs e lmkl - mrxiviwx hifx.Jsv xlswi als evi hiit mr gvihmx gevh hifx, xlivi evi wsqi Gvihmx Wivzmgiw ekirgmiw xlex sjjiv ercsri mr Eqivmge fsxl srpmri sv xipitlsri, erh jegi - xs - jegi gsyrwipmrk.Xli gsyrwipsvw qec tvstswi e hifx qerekiqirx tper.Xli tper mrgpyhiw psaiv mrxiviwx tecqirxw jsv gpmirxw erh wixxmrk yt e tec sjj xmqixefpi.Xli ekirgmiw’ eziveki gpmirx qeoiw efsyx $32, 000 e ciev erh lew qsvi xler $16, 000 hifx mr xli tvskveq.Ywyeppc xli ekirgmiw glevki divs yt xs $30 qsrxlpc xs qereki xli hifx wivzmgi tper.Gvihmx Wivzmgiw gsyrwipsvw ehzmwi, xlex mj er Eqivmger kixw hmzsvgih, li sv wli qec ipmqmrexi epp nsmrx hifxw fc tecmrk xliq sjj sv xverwjivvmrk hifx mrxs e sri-reqi eggsyrx.Izir mr lettc qevvmekiw, xli ekirgc ehzmwiw xlex xli lywferh erh amji wlsyph iegl lezi e gvihmx gevh mr xlimv reqi srpc xs iwxefpmwl witevexi gvihmx lmwxsvmiw.Srgi hifxw lezi fiir vitemh, er Eqivmger ger vi-iwxefpmwl lmw / liv kssh gvihmx fc ettpcmrk jsv e wigyvih gvihmx gevh erh tecmrk xli fepergi sjj vikypevpc.E wxsvi gvihmx gevh ywyeppc mw xli ribx wxit, jsppsaih fc ettpcmrk jsv e qensv gvihmx gevh wygl ew e Zmwe sv QewxivGevh.(Ehetxih jvsq \"Mrhmeretspmw Asqer\")", "Latin"));
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine(ts);
            sw.Restart();
            Console.WriteLine(cipher.Hack("«Ч пчотртфаг иче лйпйсян…» — хцфтом, лсдотряй одкитрч х ийцхцжд. Жтпьйесян рмф учьомсхомщ ходлто сдхцтпаот уфтыст жтьйп ж сдьч кмлса, ыцт жтхуфмсмрдйцхг одо сйтцюйрпйрдг ыдхца фчххотн очпацчфя. Утбрд «Фчхпдс м Пвирмпд» еяпд лдотсыйсд Учьомсяр ж 1820 з., ст жхцчупйсмй тс итумхдп ж 1825 з. ж Рмщднптжхотр. Лд йзт тхстжч утбц жлгп уфмходлоч Дфмся Фтимтстжся.Жхцчупйсмй Учьомсд о утбрй уфтитпкдйц ифйжсмй цфдимъмм фчххотзт штпаоптфд.Йэй ифйжсйфчххомй зчхпгфя сдымсдпм хжтм ходлдсмг х теглдцйпастн уфмходлом, сй мрйвэйн уфгртзт тцстьйсмг о хвкйцч.Бцд уфмходлод сдхцфдмждпд хпчьдцйпйн сд цтфкйхцжйссян пди, хтлидждпд тхтечв жтпьйесчв дцртхшйфч.Учьомс сдымсдйц хжтв утбрч тумхдсмйр цдмсхцжйсстзт пчотртфаг – лдздитыстн рйхцстхцм, зий жтлрткся пвеяй ычийхд. «Отц чыйсян» хмржтпмлмфчйц ифйжсйзт джцтфд - ходлмцйпг, отцтфян лсдйц сйжйфтгцстй отпмыйхцжт ходлто м уйхйс.Пчотртфай сдхйпйст рсткйхцжтр жтпьйесящ зйфтйж, хтефджьмщхг лийха мл жхйщ фчххомщ ходлто.Хфйим смщ м жцтфтхцйуйссяй уйфхтсдкм(пйьмн, фчхдпод), м «сйжмидссяй лжйфм», м утод йэй сйтичьйжпйссдг млечьод сд очфамщ сткодщ.Утхцйуйсст уйфйи ымцдцйпйр жтлсмодвц м етпйй лсдымряй зйфтм.Хфйим сйгхсящ жмийсмн утгжпгвцхг ртзчымй «цфмиъдца жмцглйн» жт зпджй х Ыйфстртфтр, хмржтпмлмфчвэмй жтйссчв хмпч фчххотзт сдфтид.Зпджсяй утпткмцйпасяй уйфхтсдкм(отфтпйжмы, етздцяфа, ъдфйжсд) утод йэй ейляргсся.Тсм гжпгвцхг хтемфдцйпасярм тефдлдрм, отцтфяр уфйихцтмц жтуптцмцахг ж отсофйцстн ходлой.Лджйфьдвц жтпьйесчв одфцмсч тхстжсяй тцфмъдцйпасяй уйфхтсдкм – Едед - Гзд м Одэйн Ейххрйфцсян, тпмъйцжтфгвэмй лпт м сйхуфджйипмжтхца. Учьомс утиыйфомждйц, ыцт жйха бцтц жтпьйесян рмф мрййц сдъмтсдпасяй отфсм.Тс сйутхфйихцжйсст хжглдс х Фтххмйн: «цдр Фчхав удщсйц!». Жхй уфтмхщтигэмй ж бцтр рмфй хтеяцмг(утижмзм, жфйрйссяй утейия лптиййж м цтфкйхцжт хуфджйипмжтхцм) гжпгвцхг тцфдкйсмйр фйдпастн кмлсм.Ходлом – бцт сй цтпаот жяичрдссяй ипг фдлжпйыйсмг мхцтфмм.Тсм ут хжтйрч тхжйэдвц ийнхцжмцйпастхца м утртздвц ыйптжйоч фдлпмыдца итефт м лпт.Ж шмсдпй уфмходлом Учьомс чцжйфкидйц, ыцт хдр утеяждп ж пчотртфай м хпчьдп ходлом «отцд чыйстзт». Тс щтыйц утийпмцахг тистн мл цдомщ уфйофдхсящ ходлто.Мсцфмзчвэйй жхцчупйсмй утбцд чхмпмждйц мсцйфйх ымцдцйпйн м сйцйфуйсмй уйфйи жхцчупйсмйр ж жтпьйесян рмф сдфтисящ уфйидсмн.",
                "Cyrillic"));
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine(ts);
            Console.ReadLine();
        }
    }
}
