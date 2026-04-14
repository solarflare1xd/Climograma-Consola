



using System.Runtime.InteropServices;
using System.Threading;
double[] Temp = new double[12];
double[] Preci = new double[12];
string[] nombreMes = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
string[] ClimaTipo = new string[12];
string[] PrecipitacionTipo = new string[12];
double acumTemp = 0;
double acumPreci = 0;
double promedioTemp = 0;
double promedioPreci = 0;
ConsoleKey OP;
//verano (diciembre-marzo), otoño (marzo-junio), invierno (junio-septiembre) y primavera (septiembre-diciembre)


while (!Console.KeyAvailable) // Se repite meintra no toques 
{
    //PRIMERO
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"
                      .,-:::::   :::     :::.        :       ...       .,-:::::/ :::::::..    :::.     .        :    :::.     
                    ,;;;'````'   ;;;     ;;;;;,.    ;;;   .;;;;;;;.  ,;;-'````'  ;;;;``;;;;   ;;`;;    ;;,.    ;;;   ;;`;;    
                    [[[          [[[     [[[[[[[, ,[[[[, ,[[     \[[,[[[   [[[[[[/[[[,/[[['  ,[[ '[[,  [[[[, ,[[[[, ,[[ '[[,  
                    $$$          $$'     $$$$$$$$$$$""$$$ $$$,     $$$""$$c.    ""$$ $$$$$$c   c$$$cc$$$c $$$$$$$$""$$$c$$$cc$$$c 
                    `88bo,__,o, o88oo,.__888888 Y88"" 888o""888,_ _,88P `Y8bo,,,o88o888b ""88bo,888   888,888 Y88"" 888o888   888,
                      ""YUMMMMMP""""""""""YUMMMMMMMMM  M'  ""MMM  ""YMMMMMP""    `'YMUP""YMMMMMM   ""W"" YMM   """"` MMM  M'  ""MMMYMM   """"` 
");




    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("                                                                              000      00");
    Console.WriteLine("                                                                          0000000   0000");
    Console.WriteLine("                                                              0      00  00000000000000000");
    Console.WriteLine("                                                           0000 0  000000000000000000000000       0");
    Console.WriteLine("                                                         000000000000000000000000000000000000000 000");
    Console.WriteLine("                                                        0000000000000000000000000000000000000000000000");
    Console.WriteLine("                                                            0000000000000000000000000000000000000000000000");
    Console.WriteLine("                                                  000000000000000000000000000000000000000000000000");
    Console.WriteLine("                                                00000000000000000000000000000000000000000000000000000000");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("                                                             / / / / / / / / / / / / / / / /");
    Console.WriteLine("                                                            / / / / / / / / / / / / / / /");
    Console.WriteLine("                                                            / / / / / / / / / / / / / / /");
    Console.WriteLine("                                                              / / / / / / / / / / / / / /");
    Console.WriteLine("                                                              / / / / / / / / / / / / /");
    Console.WriteLine("                                                            / / / / / / / / / / / /");
    Console.WriteLine("                                                           / / / / / / / / / /");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("                                                               Presione Enter para Continuar.");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("adfakpjafadsfjipadfjopasfopasfjkopadsfjkopfasopfasasfjkpfasjkpafjkpasf");


    Thread.Sleep(100); //p0ausa

    if (Console.KeyAvailable)
        break;


    //SEGUNDO
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@"
                      .,-:::::   :::     :::.        :       ...       .,-:::::/ :::::::..    :::.     .        :    :::.     
                    ,;;;'````'   ;;;     ;;;;;,.    ;;;   .;;;;;;;.  ,;;-'````'  ;;;;``;;;;   ;;`;;    ;;,.    ;;;   ;;`;;    
                    [[[          [[[     [[[[[[[, ,[[[[, ,[[     \[[,[[[   [[[[[[/[[[,/[[['  ,[[ '[[,  [[[[, ,[[[[, ,[[ '[[,  
                    $$$          $$'     $$$$$$$$$$$""$$$ $$$,     $$$""$$c.    ""$$ $$$$$$c   c$$$cc$$$c $$$$$$$$""$$$c$$$cc$$$c 
                    `88bo,__,o, o88oo,.__888888 Y88"" 888o""888,_ _,88P `Y8bo,,,o88o888b ""88bo,888   888,888 Y88"" 888o888   888,
                      ""YUMMMMMP""""""""""YUMMMMMMMMM  M'  ""MMM  ""YMMMMMP""    `'YMUP""YMMMMMM   ""W"" YMM   """"` MMM  M'  ""MMMYMM   """"` 
");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("                                                                              000      00");
    Console.WriteLine("                                                                          0000000   0000");
    Console.WriteLine("                                                              0      00  00000000000000000");
    Console.WriteLine("                                                           0000 0  000000000000000000000000       0");
    Console.WriteLine("                                                         000000000000000000000000000000000000000 000");
    Console.WriteLine("                                                        0000000000000000000000000000000000000000000000");
    Console.WriteLine("                                                            0000000000000000000000000000000000000000000000");
    Console.WriteLine("                                                  000000000000000000000000000000000000000000000000");
    Console.WriteLine("                                                00000000000000000000000000000000000000000000000000000000");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("                                                             / / / / / / / / / / / / / / / /");
    Console.WriteLine("                                                            / / / / / / / / / / / / / / /");
    Console.WriteLine("                                                            / / / / / / / / / / / / / / /");
    Console.WriteLine("                                                              / / / / / / / / / / / / / /");
    Console.WriteLine("                                                              / / / / / / / / / / / / /");
    Console.WriteLine("                                                            / / / / / / / / / / / /");
    Console.WriteLine("                                                           / / / / / / / / / /");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("                                                               Presione Enter para Continuar.");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Creado por Federico Mendoza y Dimas Godoy");


    Thread.Sleep(100);

    if (Console.KeyAvailable)
        break;



    //TERCERO
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@"
                      .,-:::::   :::     :::.        :       ...       .,-:::::/ :::::::..    :::.     .        :    :::.     
                    ,;;;'````'   ;;;     ;;;;;,.    ;;;   .;;;;;;;.  ,;;-'````'  ;;;;``;;;;   ;;`;;    ;;,.    ;;;   ;;`;;    
                    [[[          [[[     [[[[[[[, ,[[[[, ,[[     \[[,[[[   [[[[[[/[[[,/[[['  ,[[ '[[,  [[[[, ,[[[[, ,[[ '[[,  
                    $$$          $$'     $$$$$$$$$$$""$$$ $$$,     $$$""$$c.    ""$$ $$$$$$c   c$$$cc$$$c $$$$$$$$""$$$c$$$cc$$$c 
                    `88bo,__,o, o88oo,.__888888 Y88"" 888o""888,_ _,88P `Y8bo,,,o88o888b ""88bo,888   888,888 Y88"" 888o888   888,
                      ""YUMMMMMP""""""""""YUMMMMMMMMM  M'  ""MMM  ""YMMMMMP""    `'YMUP""YMMMMMM   ""W"" YMM   """"` MMM  M'  ""MMMYMM   """"` 
");




    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("                                                                              000      00");
    Console.WriteLine("                                                                          0000000   0000");
    Console.WriteLine("                                                              0      00  00000000000000000");
    Console.WriteLine("                                                           0000 0  000000000000000000000000       0");
    Console.WriteLine("                                                         000000000000000000000000000000000000000 000");
    Console.WriteLine("                                                        0000000000000000000000000000000000000000000000");
    Console.WriteLine("                                                            0000000000000000000000000000000000000000000000");
    Console.WriteLine("                                                  000000000000000000000000000000000000000000000000");
    Console.WriteLine("                                                00000000000000000000000000000000000000000000000000000000");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("                                                             / / / / / / / / / / / / / / / /");
    Console.WriteLine("                                                            / / / / / / / / / / / / / / /");
    Console.WriteLine("                                                            / / / / / / / / / / / / / / /");
    Console.WriteLine("                                                              / / / / / / / / / / / / / /");
    Console.WriteLine("                                                              / / / / / / / / / / / / /");
    Console.WriteLine("                                                            / / / / / / / / / / / /");
    Console.WriteLine("                                                           / / / / / / / / / /");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("                                                               Presione Enter para Continuar..");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Creado por Federico Mendoza y Dimas Godoy");


    Thread.Sleep(100);
    if (Console.KeyAvailable)
        break;



    //CUARTO
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
                      .,-:::::   :::     :::.        :       ...       .,-:::::/ :::::::..    :::.     .        :    :::.     
                    ,;;;'````'   ;;;     ;;;;;,.    ;;;   .;;;;;;;.  ,;;-'````'  ;;;;``;;;;   ;;`;;    ;;,.    ;;;   ;;`;;    
                    [[[          [[[     [[[[[[[, ,[[[[, ,[[     \[[,[[[   [[[[[[/[[[,/[[['  ,[[ '[[,  [[[[, ,[[[[, ,[[ '[[,  
                    $$$          $$'     $$$$$$$$$$$""$$$ $$$,     $$$""$$c.    ""$$ $$$$$$c   c$$$cc$$$c $$$$$$$$""$$$c$$$cc$$$c 
                    `88bo,__,o, o88oo,.__888888 Y88"" 888o""888,_ _,88P `Y8bo,,,o88o888b ""88bo,888   888,888 Y88"" 888o888   888,
                      ""YUMMMMMP""""""""""YUMMMMMMMMM  M'  ""MMM  ""YMMMMMP""    `'YMUP""YMMMMMM   ""W"" YMM   """"` MMM  M'  ""MMMYMM   """"` 
");





    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("");
    Console.WriteLine(@"                                                                              |");
    Console.WriteLine(@"                                                                              |");
    Console.WriteLine(@"                                                                \    *        |     *    .  /");
    Console.WriteLine(@"                                                                  \        *  |  .        /");
    Console.WriteLine(@"                                                               .    \     ___---___     /    .  ");
    Console.WriteLine(@"                                                                      \.--         --./     ");
    Console.WriteLine(@"                                                           ~-_    *  ./               \.   *   _-~");
    Console.WriteLine(@"                                                               ~-_   /                   \   _-~     *");
    Console.WriteLine(@"                                                         *       ~-/                     \-~        ");
    Console.WriteLine(@"                                                           .      |                       |      .");
    Console.WriteLine(@"                                                               * |                         | *     ");
    Console.WriteLine(@"                                                      -----------|                         |-----------");
    Console.WriteLine(@"                                                        .        |                         |        .    ");
    Console.WriteLine(@"                                                              *   |                       | *");
    Console.WriteLine(@"                                                                 _-\                     /-_    *");
    Console.WriteLine(@"                                                           .  _-~ . \                   /   ~-_     ");
    Console.WriteLine(@"                                                         _ -~       `\               /'*      ~-_  ");
    Console.WriteLine(@"                                                         ~           /`--___   ___--'\           ~");
    Console.WriteLine(@"                                                                *  /        ---     .  \  ");
    Console.WriteLine(@"                                                                  /     *     |           \");
    Console.WriteLine(@"                                                                /             |   *         \");
    Console.WriteLine(@"                                                                           .  |        .");
    Console.WriteLine(@"                                                                              |");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("                                                               Presione Enter para Continuar...");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Creado por Federico Mendoza y Dimas Godoy");


    Thread.Sleep(100);
    if (Console.KeyAvailable)
        break;



    //QUINTO
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@"
                      .,-:::::   :::     :::.        :       ...       .,-:::::/ :::::::..    :::.     .        :    :::.     
                    ,;;;'````'   ;;;     ;;;;;,.    ;;;   .;;;;;;;.  ,;;-'````'  ;;;;``;;;;   ;;`;;    ;;,.    ;;;   ;;`;;    
                    [[[          [[[     [[[[[[[, ,[[[[, ,[[     \[[,[[[   [[[[[[/[[[,/[[['  ,[[ '[[,  [[[[, ,[[[[, ,[[ '[[,  
                    $$$          $$'     $$$$$$$$$$$""$$$ $$$,     $$$""$$c.    ""$$ $$$$$$c   c$$$cc$$$c $$$$$$$$""$$$c$$$cc$$$c 
                    `88bo,__,o, o88oo,.__888888 Y88"" 888o""888,_ _,88P `Y8bo,,,o88o888b ""88bo,888   888,888 Y88"" 888o888   888,
                      ""YUMMMMMP""""""""""YUMMMMMMMMM  M'  ""MMM  ""YMMMMMP""    `'YMUP""YMMMMMM   ""W"" YMM   """"` MMM  M'  ""MMMYMM   """"` 
");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("");
    Console.WriteLine(@"                                                                              |");
    Console.WriteLine(@"                                                                              |");
    Console.WriteLine(@"                                                                \    *        |     *    .  /");
    Console.WriteLine(@"                                                                  \        *  |  .        /");
    Console.WriteLine(@"                                                               .    \     ___---___     /    .  ");
    Console.WriteLine(@"                                                                      \.--         --./     ");
    Console.WriteLine(@"                                                           ~-_    *  ./               \.   *   _-~");
    Console.WriteLine(@"                                                               ~-_   /                   \   _-~     *");
    Console.WriteLine(@"                                                         *       ~-/                     \-~        ");
    Console.WriteLine(@"                                                           .      |                       |      .");
    Console.WriteLine(@"                                                               * |                         | *     ");
    Console.WriteLine(@"                                                      -----------|                         |-----------");
    Console.WriteLine(@"                                                        .        |                         |        .    ");
    Console.WriteLine(@"                                                              *   |                       | *");
    Console.WriteLine(@"                                                                 _-\                     /-_    *");
    Console.WriteLine(@"                                                           .  _-~ . \                   /   ~-_     ");
    Console.WriteLine(@"                                                         _ -~       `\               /'*      ~-_  ");
    Console.WriteLine(@"                                                         ~           /`--___   ___--'\           ~");
    Console.WriteLine(@"                                                                *  /        ---     .  \  ");
    Console.WriteLine(@"                                                                  /     *     |           \");
    Console.WriteLine(@"                                                                /             |   *         \");
    Console.WriteLine(@"                                                                           .  |        .");
    Console.WriteLine(@"                                                                              |");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("                                                               Presione Enter para Continuar...");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Creado por Federico Mendoza y Dimas Godoy");
    
    Thread.Sleep(100);
}





Console.ResetColor();

Console.ReadKey(true);


Console.Clear();


Console.WriteLine(@"











               ________/\\\\\\\\\________________________________________________________________________________/\\\________________        
                _____/\\\////////_______________________________________________________________________________\/\\\________________       
                 ___/\\\/__________________________________________/\\\\\\\\______________________________________\/\\\________________      
                  __/\\\______________/\\\\\\\\\_____/\\/\\\\\\\___/\\\////\\\__/\\\\\\\\\_____/\\/\\\\\\__________\/\\\______/\\\\\____     
                   _\/\\\_____________\////////\\\___\/\\\/////\\\_\//\\\\\\\\\_\////////\\\___\/\\\////\\\____/\\\\\\\\\____/\\\///\\\__    
                    _\//\\\______________/\\\\\\\\\\__\/\\\___\///___\///////\\\___/\\\\\\\\\\__\/\\\__\//\\\__/\\\////\\\___/\\\__\//\\\_   
                     __\///\\\___________/\\\/////\\\__\/\\\__________/\\_____\\\__/\\\/////\\\__\/\\\___\/\\\_\/\\\__\/\\\__\//\\\__/\\\__  
                      ____\////\\\\\\\\\_\//\\\\\\\\/\\_\/\\\_________\//\\\\\\\\__\//\\\\\\\\/\\_\/\\\___\/\\\_\//\\\\\\\/\\__\///\\\\\/___ 
                       _______\/////////___\////////\//__\///___________\////////____\////////\//__\///____\///___\///////\//_____\/////_____
                                                                                                         ");
Thread.Sleep(1000);
Console.Clear();

for (int i = 0; i < 12; i++)
{
    do
    {
        Console.Clear();


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                                                                   ______________________");
        Console.WriteLine("                                                                   |   ^F     _    ^C   |");

        Console.Write("                                                                   |  100  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("  40  |");

        Console.Write("                                                                   |   90  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("  30  |");

        Console.Write("                                                                   |   80  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("  25  |");

        Console.Write("                                                                   |   70  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("  20  |");

        Console.Write("                                                                   |   60  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("  15  |");

        Console.Write("                                                                   |   50  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("  10  |");

        Console.Write("                                                                   |   40  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("  10  |");

        Console.Write("                                                                   |   30  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("   5  |");

        Console.Write("                                                                   |   20  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("   0  |");

        Console.Write("                                                                   |   10  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine("  -5  |");

        Console.Write("                                                                   |    0  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine(" -20  |");

        Console.Write("                                                                   |  -10  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" | | ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine(" -25  |");

        Console.Write("                                                                   |  -20  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" |_| ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine(" -30  |");

        Console.Write("                                                                   |  -30  ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("-");
        Console.ResetColor();
        Console.Write(" |*| ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("-");
        Console.ResetColor();
        Console.WriteLine(" -35  |");

        Console.WriteLine("                                                                   |        '***`       |");
        Console.WriteLine("                                                                   |       (*****)      |");
        Console.WriteLine("                                                                   |        `---'       |");
        Console.WriteLine("                                                                   |____________________|");

        Console.WriteLine("");
        Console.WriteLine("Ingrese el promedio de temperatura de " + nombreMes[i]);


        if (double.TryParse(Console.ReadLine().Replace(".", ","), out Temp[i])) //comando raro para que solo acepte numero y remplazar . por ,
        {

            if (Temp[i] < -89)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                          La temperatura no puede ser menor a -89 grados Celsius. Por favor, ingrese un valor válido.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(@"                                                  
                                                                  
                                                                                ████████                      
                                                                            ████░░░░░░░░████                  
                                                                        ████░░░░░░░░░░░░░░░░████              
                                                                    ████░░░░░░░░░░░░░░░░░░░░░░░░████          
                                                                    ██░░████░░░░░░░░░░░░░░░░████  ██          
                                                                    ██░░░░░░████░░░░░░░░████░░  ░░██          
                                                                    ██░░░░░░░░░░████████░░░░  ░░░░██          
                                                                    ██░░░░░░  ░░░░░░██░░░░░░░░░░░░██          
                                                                    ██░░░░  ░░░░░░░░██░░░░░░░░░░░░██          
                                                                    ██░░  ░░░░░░░░░░██░░░░░░  ░░░░██          
                                                                    ██░░░░░░░░░░░░  ██░░░░  ░░░░░░██          
                                                                    ██░░░░░░░░░░  ░░██░░  ░░░░░░░░██          
                                                                    ████░░░░░░  ░░░░██░░░░░░░░░░████          
                                                                        ████░░░░░░░░██░░░░░░████              
                                                                            ████░░░░██░░████                  
                                                                                ████████                      
                                                  
                                                  
                                                  
                                                  
");

                Console.ResetColor();
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                continue;
            }


            if (Temp[i] > 57)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                            La temperatura no puede ser mayor a 57 grados Celsius. Por favor, ingrese un valor válido.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(@"         
                                                                               ▒▒                                
                                                                               ▓▓                                
                                                                               ▓▓▓▓                              
                                                                               ████                              
                                                                             ░░████                              
                                                                             ██▓▓██                              
                                                                       ░░  ████▓▓▓▓    ▒▒                        
                                                                       ▓▓▒▒▓▓██▒▒▓▓  ██░░                        
                                                                     ▓▓██████▒▒▓▓▒▒████  ▒▒                      
                                                                     ██████▒▒▒▒▓▓▒▒██▒▒  ██                      
                                                                     ██▓▓▓▓░░▒▒████▓▓░░▒▒██  ░░                  
                                                                     ██▒▒▒▒░░▒▒▓▓██▓▓▓▓████▓▓░░                  
                                                                     ██▒▒▒▒░░▒▒████▓▓██▓▓████░░                  
                                                                     ██▒▒░░░░▒▒▓▓██▒▒██▒▒██▓▓░░                  
                                                                 ░░  ▒▒▒▒░░░░░░▒▒██░░▒▒▒▒▓▓██                    
                                                                   ██▓▓▓▓░░  ░░▒▒▒▒░░░░▒▒▓▓▓▓                    
                                                                   ░░██▓▓▒▒░░  ░░░░░░░░░░▓▓░░                    
                                                                     ░░▓▓░░░░        ░░▒▒░░                      
                                                                         ░░▒▒░░      ░░            ");

                Console.ResetColor();
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                continue;
            }


            break;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(@"  





                                                                                                   
                                    EEEEEEEEEEEEEEEEEEEEEE                                                                             
                                    E::::::::::::::::::::E                                                                             
                                    E::::::::::::::::::::E                                                                             
                                    EE::::::EEEEEEEEE::::E                                                                             
                                      E:::::E       EEEEEErrrrr   rrrrrrrrr   rrrrr   rrrrrrrrr      ooooooooooo   rrrrr   rrrrrrrrr   
                                      E:::::E             r::::rrr:::::::::r  r::::rrr:::::::::r   oo:::::::::::oo r::::rrr:::::::::r  
                                      E::::::EEEEEEEEEE   r:::::::::::::::::r r:::::::::::::::::r o:::::::::::::::or:::::::::::::::::r 
                                      E:::::::::::::::E   rr::::::rrrrr::::::rrr::::::rrrrr::::::ro:::::ooooo:::::orr::::::rrrrr::::::r
                                      E:::::::::::::::E    r:::::r     r:::::r r:::::r     r:::::ro::::o     o::::o r:::::r     r:::::r
                                      E::::::EEEEEEEEEE    r:::::r     rrrrrrr r:::::r     rrrrrrro::::o     o::::o r:::::r     rrrrrrr
                                      E:::::E              r:::::r             r:::::r            o::::o     o::::o r:::::r            
                                      E:::::E       EEEEEE r:::::r             r:::::r            o::::o     o::::o r:::::r            
                                    EE::::::EEEEEEEE:::::E r:::::r             r:::::r            o:::::ooooo:::::o r:::::r            
                                    E::::::::::::::::::::E r:::::r             r:::::r            o:::::::::::::::o r:::::r            
                                    E::::::::::::::::::::E r:::::r             r:::::r             oo:::::::::::oo  r:::::r            
                                    EEEEEEEEEEEEEEEEEEEEEE rrrrrrr             rrrrrrr               ooooooooooo    rrrrrrr            
                                                                                                   
                                                   
                                                                                                   
                                                                                                   
                                                                                                   
                                                                                                   
                                                                                                ");

            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();

        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
      $$\            $$\                          $$\                           $$\                                                                   
      \__|           $$ |                         $$ |                          $$ |                                                                  
      $$\ $$$$$$$\ $$$$$$\    $$$$$$\  $$$$$$$\ $$$$$$\    $$$$$$\         $$$$$$$ | $$$$$$\        $$$$$$$\  $$\   $$\  $$$$$$\ $$\    $$\  $$$$$$\  
      $$ |$$  __$$\\_$$  _|  $$  __$$\ $$  __$$\\_$$  _|  $$  __$$\       $$  __$$ |$$  __$$\       $$  __$$\ $$ |  $$ |$$  __$$\\$$\  $$  |$$  __$$\ 
      $$ |$$ |  $$ | $$ |    $$$$$$$$ |$$ |  $$ | $$ |    $$$$$$$$ |      $$ /  $$ |$$$$$$$$ |      $$ |  $$ |$$ |  $$ |$$$$$$$$ |\$$\$$  / $$ /  $$ |
      $$ |$$ |  $$ | $$ |$$\ $$   ____|$$ |  $$ | $$ |$$\ $$   ____|      $$ |  $$ |$$   ____|      $$ |  $$ |$$ |  $$ |$$   ____| \$$$  /  $$ |  $$ |
      $$ |$$ |  $$ | \$$$$  |\$$$$$$$\ $$ |  $$ | \$$$$  |\$$$$$$$\       \$$$$$$$ |\$$$$$$$\       $$ |  $$ |\$$$$$$  |\$$$$$$$\   \$  /   \$$$$$$  |
      \__|\__|  \__|  \____/  \_______|\__|  \__|  \____/  \_______|       \_______| \_______|      \__|  \__| \______/  \_______|   \_/     \______/ 
                                                                                                                                                
                                                                                                                                                
                                                                                                                                                 ");
        System.Threading.Thread.Sleep(1000);
        Console.ResetColor();


        Console.ResetColor();
        Console.Clear();



    } while (true);
}





for (int i = 0; i < 12; i++)
{
    do
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine(@"
                                                ------               _____                          ------               _____
                                               /      \ ___\     ___/    ___                       /      \ ___\     ___/    ___
                                            --/-  ___  /    \/  /  /    /   \                   --/-  ___  /    \/  /  /    /   \
                                          /     /           \__     //_     \                 /     /           \__     //_     \
                                          /                     \   / ___     |               /                     \   / ___     |
                                          |           ___       \/+--/        /               |           ___       \/+--/        /
                                           \__           \       \           /                 \__           \       \           /
                                              \__                 |          /                    \__                 |          /     
                                             \     /____      /  /       |   /                   \     /____      /  /       |   /     
                                              _____/         ___       \/  /\                     _____/         ___       \/  /\        
                                                   \__      /      /    |    |                          \__      /      /    |    |       
                                                 /    \____/   \       /   //                         /    \____/   \       /   //                                 
                                             // / / // / /\    /-_-/\//-__-                       // / / // / /\    /-_-/\//-__-               
                                              /  /  // /   \__// / / /  //                         /  /  // /   \__// / / /  //
                                             //   / /   //   /  // / // /                         //   / /   //   /  // / // /
                                              /// // / /   /  //  / //                             /// // / /   /  //  / //
                                           //   //       //  /  // / /                          //   //       //  /  // / /
                                             / / / / /     /  /    /                            / / / / /     /  /    /
                                          ///  / / /  //  // /  // //                        ///  / / /  //  // /  // //
                                             ///    /    /    / / / /                           ///    /    /    / / / /
                                        ///  /    // / /  // / / /  /                    ///  /    // / /  // / / /  /
                                           // ///   /      /// / /                          // ///   /      /// / /");

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("                                                          Ingrese la precipitación de " + nombreMes[i]);


        if (double.TryParse(Console.ReadLine().Replace(".", ","), out Preci[i])) //comando raro para que solo acepte numero y remplazar . por ,
        {

            if (Preci[i] < 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                           La precipitacion no puede ser menor a 0 mm ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(@"
        .       _    +      .      ______      .        .       _    +      .      ______      .        .       _    +      .      ______      .
   (      /|\        .      |      \        +      (    /|\        .      |      \        +      (        /|\        .      |      \        +
       . |||||      _       | |   | | ||        .   .  |||||      _       | |   | | ||        .   .      |||||      _       | |   | | ||        .
 .      |||||     | |    __| | | | |_||     .   .     |||||     | |    __| | | | |_||     .   .          |||||     | |    __| | | | |_||     .
     /\ ||||| .   | |   |   | | |     |       .    /\ ||||| .   | |   |   | | |     |       .      /\    ||||| .   | |   |   | | |     |       .
 ___||||_|||||____|_|___|___|_|_|_____|___________||||_|||||____|_|___|___|_|_|_____|___________  ||||   |||||____|_|___|___|_|_|_____|___________
 .  |||| |||||  /\    _____      _____   .    .   |||| |||||   /\    _____      _____   .    .    ||||   |||||    /\    _____      _____   .    .
    |||| ||||| ||||  .     .  .           ______  |||| |||||  ||||  .     .  .           ______   ||||   |||||   ||||  .     .  .           ______
 .  \|`-'|||| ||||    __________        .     .   \|`-'||||   ||||    __________        .     .    \|`-' ||||   ||||    __________        .     .
     \__ |||| ||||      .        .    .             \__ ||||  ||||      .        .    .             \|   ||||  ||||      .        .    .
  __    ||||`-'|||   .      .      __________     __    ||||`   |||   .      .      __________       \__||||`-|||   .      .      __________
 .    . |||| ___/  ____________            .      .    .|||| ___/  ____________            .      .    .|||| ___/  ____________            .
      _ ||||| . _               .   _________         _ ||||| . _               .   _________         _ ||||| . _               .   _________
  _  ___|||||__  _ \\--//   .         _               _ |||||__  _     \\--//   .         _          ___|||||__  _ \\--//   .         _
       _ `---'    .(o  o).    _   .   .                    _ `---'    .(o  o).    _   .   .                    _ `---'    .(o  o).    _   .   .
  _  ^      .  -    .\_/   .        .              _  ^      .  -    .  \_/   .        .             _  ^      .  -    .    \_/   .        .");


                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                continue;
            }


            if (Preci[i] > 5000)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                            La precipitacion no puede ser mayor a 5000 mm ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(@"
                                                   . '@(@@@@@@@)@. (@@) `  .   '
                                              .  @@'((@@@@@@@@@@@)@@@@@)@@@@@@@)@ 
                                              @@(@@@@@@@@@@))@@@@@@@@@@@@@@@@)@@` .
                                           @.((@@@@@@@)(@@@@@@@@@@@@@@))@\@@@@@@@@@)@@@  .
                                          (@@@@@@@@@@@@@@@@@@)@@@@@@@@@@@\\@@)@@@@@@@@)
                                         (@@@@@@@@)@@@@@@@@@@@@@(@@@@@@@@//@@@@@@@@@) ` 
                                          .@(@@@@)##&&&&&(@@@@@@@@)::_=(@\\@@@@)@@ .   .'
                                            @@`(@@)###&&&&&!!;;;;;;::-_=@@\\@)@`@.
                                            `   @@(@###&&&&!!;;;;;::-=_=@.@\\@@     '
                                               `  @.#####&&&!!;;;::=-_= .@  \\
                                                     ####&&&!!;;::=_-        `
                                                      ###&&!!;;:-_=
                                                       ##&&!;::_=
                                                      ##&&!;:=
                                                     ##&&!:-
                                                    #&!;:-
                                                   #&!;=
                                                   #&!-
                                                    #&=
                                                     #&-
                                                     \\#/'
                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
");


                Console.ResetColor();
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                continue;
            }


            break;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(@"  





                                                                                                   
                             EEEEEEEEEEEEEEEEEEEEEE                                                                             
                             E::::::::::::::::::::E                                                                             
                             E::::::::::::::::::::E                                                                             
                             EE::::::EEEEEEEEE::::E                                                                             
                               E:::::E       EEEEEErrrrr   rrrrrrrrr   rrrrr   rrrrrrrrr      ooooooooooo   rrrrr   rrrrrrrrr   
                               E:::::E             r::::rrr:::::::::r  r::::rrr:::::::::r   oo:::::::::::oo r::::rrr:::::::::r  
                               E::::::EEEEEEEEEE   r:::::::::::::::::r r:::::::::::::::::r o:::::::::::::::or:::::::::::::::::r 
                               E:::::::::::::::E   rr::::::rrrrr::::::rrr::::::rrrrr::::::ro:::::ooooo:::::orr::::::rrrrr::::::r
                               E:::::::::::::::E    r:::::r     r:::::r r:::::r     r:::::ro::::o     o::::o r:::::r     r:::::r
                               E::::::EEEEEEEEEE    r:::::r     rrrrrrr r:::::r     rrrrrrro::::o     o::::o r:::::r     rrrrrrr
                               E:::::E              r:::::r             r:::::r            o::::o     o::::o r:::::r            
                               E:::::E       EEEEEE r:::::r             r:::::r            o::::o     o::::o r:::::r            
                             EE::::::EEEEEEEE:::::E r:::::r             r:::::r            o:::::ooooo:::::o r:::::r            
                             E::::::::::::::::::::E r:::::r             r:::::r            o:::::::::::::::o r:::::r            
                             E::::::::::::::::::::E r:::::r             r:::::r             oo:::::::::::oo  r:::::r            
                             EEEEEEEEEEEEEEEEEEEEEE rrrrrrr             rrrrrrr               ooooooooooo    rrrrrrr            
                                                                                                   
                                                   
                                                                                                   
                                                                                                   
                                                                                                   
                                                                                                   
                                                                                                ");

            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();

        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
      $$\            $$\                          $$\                           $$\                                                                   
      \__|           $$ |                         $$ |                          $$ |                                                                  
      $$\ $$$$$$$\ $$$$$$\    $$$$$$\  $$$$$$$\ $$$$$$\    $$$$$$\         $$$$$$$ | $$$$$$\        $$$$$$$\  $$\   $$\  $$$$$$\ $$\    $$\  $$$$$$\  
      $$ |$$  __$$\\_$$  _|  $$  __$$\ $$  __$$\\_$$  _|  $$  __$$\       $$  __$$ |$$  __$$\       $$  __$$\ $$ |  $$ |$$  __$$\\$$\  $$  |$$  __$$\ 
      $$ |$$ |  $$ | $$ |    $$$$$$$$ |$$ |  $$ | $$ |    $$$$$$$$ |      $$ /  $$ |$$$$$$$$ |      $$ |  $$ |$$ |  $$ |$$$$$$$$ |\$$\$$  / $$ /  $$ |
      $$ |$$ |  $$ | $$ |$$\ $$   ____|$$ |  $$ | $$ |$$\ $$   ____|      $$ |  $$ |$$   ____|      $$ |  $$ |$$ |  $$ |$$   ____| \$$$  /  $$ |  $$ |
      $$ |$$ |  $$ | \$$$$  |\$$$$$$$\ $$ |  $$ | \$$$$  |\$$$$$$$\       \$$$$$$$ |\$$$$$$$\       $$ |  $$ |\$$$$$$  |\$$$$$$$\   \$  /   \$$$$$$  |
      \__|\__|  \__|  \____/  \_______|\__|  \__|  \____/  \_______|       \_______| \_______|      \__|  \__| \______/  \_______|   \_/     \______/ 
                                                                                                                                                
                                                                                                                                                
                                                                                                                                                 ");
        System.Threading.Thread.Sleep(1000);
        Console.ResetColor();


        Console.ResetColor();
        Console.Clear();




    } while (true);
}





//tipo clima
for (int j = 0; j < 12; j++)
{
    if (Temp[j] < 10)
    {
        ClimaTipo[j] = "Frio";
    }
    else if (Temp[j] >= 10 && Temp[j] <= 18)
    {
        ClimaTipo[j] = "Templado";
    }
    else if (Temp[j] > 18)
    {
        ClimaTipo[j] = "Calido";
    }

}
//tipo de terreno
for (int j = 0; j < 12; j++)
{
    if (Preci[j] <= 250)
    {
        PrecipitacionTipo[j] = "Desertico";
    }
    else if (Preci[j] > 250 && Preci[j] <= 500)
    {
        PrecipitacionTipo[j] = "Arido";
    }
    else if (Preci[j] > 500 && Preci[j] <= 2000)
    {
        PrecipitacionTipo[j] = "Moderadamente lluvioso";
    }
    else if (Preci[j] > 2000)
    {
        PrecipitacionTipo[j] = "Excesivamente lluvioso";
    }
}

double tempMax = double.MinValue;
double tempMin = double.MaxValue;
double preciMax = double.MinValue;
double preciMin = double.MaxValue;

//acumulado de temperatura
for (int j = 0; j < 12; j++)
{
    acumTemp = acumTemp + Temp[j];
}
//acumulado de precipitacion
for (int j = 0; j < 12; j++)
{
    acumPreci = acumPreci + Preci[j];
}

//preci max y min
for (int j = 0; j < 12; j++)
{
    if (Preci[j] > preciMax)
        preciMax = Preci[j];

    if (Preci[j] < preciMin)
        preciMin = Preci[j];
}

//temp max y min
for (int j = 0; j < 12; j++)
{
    if (Temp[j] > tempMax)
    {
        tempMax = Temp[j];
    }
    if (Temp[j] < tempMin)
    {
        tempMin = Temp[j];
    }
}
promedioPreci = acumPreci / 12;
promedioTemp = acumTemp / 12;

MostrarResultados(nombreMes, Temp, Preci, ClimaTipo, PrecipitacionTipo, promedioTemp, promedioPreci, tempMax, tempMin, preciMax, preciMin);

Console.WriteLine("                               \nPresione cualquier tecla para salir...");
Console.ReadKey();









 void MostrarResultados(string[] nombreMes, double[] Temp, double[] Preci, string[] ClimaTipo, string[] PrecipitacionTipo, double promedioTemp, double promedioPreci, double tempMax, double tempMin, double preciMax, double preciMin)
{

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("                               ================================================================================");
    Console.WriteLine("                               =                      REPORTE CLIMATOLÓGICO ANUAL                             =");
    Console.WriteLine("                               ================================================================================");
    Console.ForegroundColor = ConsoleColor.White;


    Console.WriteLine("                               MES\t\tTEMP.\t\tCLIMA\t\tPRECI.\t\tTIPO");
    Console.WriteLine("                               --------------------------------------------------------------------------------");

    for (int i = 0; i < 12; i++)
    {

        string coso = nombreMes[i].Length > 7 ? "\t" : "\t\t";


        Console.WriteLine($"                                {nombreMes[i]}{coso}{Temp[i]}°C\t\t{ClimaTipo[i]}\t\t{Preci[i]}mm\t\t{PrecipitacionTipo[i]}");
    }

    Console.WriteLine("                               --------------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Yellow;


    Console.WriteLine($"                               MÁXIMOS:\t{tempMax} °C\t\t\t\t{preciMax} mm");
    Console.WriteLine($"                               MÍNIMOS:\t{tempMin} °C\t\t\t\t{preciMin} mm");
    Console.WriteLine($"                               PROMEDIOS:\t{promedioTemp:F2} °C\t\t\t\t{promedioPreci:F2} mm");
    Console.WriteLine($"                               TOTALES:\t{acumTemp:F2} °C\t\t\t\t{acumPreci:F2} mm");


    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("                               ================================================================================");
    Console.ResetColor();


}



