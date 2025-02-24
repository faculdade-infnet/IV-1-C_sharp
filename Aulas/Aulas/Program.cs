using Aula_01;
using Aula_02;
using Aula_03;
using Aula_04;
using Aula_05;
using Aula_06;
using Aula_07;
using Aula_08;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Para executar a aula desejada, basta descomentar a linha correspondente
        //Aula01_25_01_29();
        //Aula02_25_01_31();
        //Aula03_25_02_04();
        //Aula04_25_02_07();
        //Aula05_25_02_11();
        //Aula06_25_02_14();
        //Aula07_25_02_18();
        Aula08_25_02_21();
    }


    /// <summary>
    /// <list type="bullet">    
    ///     <item>Introdução ao .Net</item>
    ///     <item>Componentes</item>
    ///     <item>Visual Studio Community 2022</item>
    ///     <item>Criando soluções e projetos</item>
    /// </list>
    /// </summary>
    private static void Aula01_25_01_29()
    {
        Aula01 aula01 = new Aula01();
        aula01.FirstProject();
    }


    /// <summary>
    /// <list type="bullet">        
    ///     <item>Tipagem</item>
    ///     <item>Value e Reference Types</item>
    ///     <item>Variáveis e escopo</item>
    ///     <item>Strings</item>
    ///     <item>Operadores Aritméticos</item>
    ///     <item>Depuração</item>
    /// </list>
    /// </summary>
    private static void Aula02_25_01_31()
    {
        var aula02 = new Aula02();
        aula02.DeclaracaoVariaveisExplicitamente();
        aula02.DeclaracaoVariaveisImplicitamente();
        aula02.DeclaracaoDeVariaveis_Escopo();
        aula02.StringsConcatenacao();
        aula02.StringInterpolacao();
        aula02.OperadoresAritmeticos();

        Console.ReadKey();
    }


    /// <summary>
    /// <list type="bullet">        
    ///     <item>Funções e Subrotinas</item>
    ///     <item>Uso Classe System.Exception</item>
    ///     <item>Tratamento de Exceções</item>
    /// </list>
    /// </summary>
    private static void Aula03_25_02_04()
    {
        var aula03_1 = new FuncoesSubrotinas();
        aula03_1.Subrotinas();
        aula03_1.Funcoes();

        var aula03_2 = new TratamentoDeExcessoes();
        aula03_2.Get();


        Console.ReadKey();
    }


    /// <summary>
    /// <list type="bullet">        
    ///     <item>Datas</item>
    ///     <item>Estruturas de Controle de Fluxo:</item>
    ///     <list type="number">        
    ///         <item>If</item>
    ///         <item>Switch</item>
    ///         <item>While</item>
    ///         <item>du While</item>
    ///         <item>For</item>
    ///         <item>Foreach</item>
    ///     </list>
    /// </list>
    /// </summary>
    private static void Aula04_25_02_07()
    {
        var aula04_1 = new Datas();
        aula04_1.Inicializacao();
        aula04_1.FormatacaoDatas();
        aula04_1.ManipulacaoPropriedades();
        aula04_1.Parse_TryParse();

        var aula04_2 = new EstruturasControleFluxo();
        aula04_2.CondicionalIf();
        aula04_2.CondicionalSwitch();
        aula04_2.EstrutruaLacoWhile();
        aula04_2.EstrutruaLacoDoWhile();
        aula04_2.EstrutruaLacoFor();
        aula04_2.EstrutruaLacoForeach();

        Console.ReadKey();
    }


    /// <summary>
    /// <list type="bullet">            
    ///     <item>Estruturas de Controle de Fluxo:</item>
    ///     <list type="number">
    ///         <item>While</item>
    ///         <item>du While</item>
    ///         <item>For</item>
    ///         <item>Foreach</item>
    ///     </list>    
    ///     <item>Nulos</item>
    /// </list>
    /// </summary>
    private static void Aula05_25_02_11()
    {
        var aula05_1 = new Nulos();
        aula05_1.IsNullo();
        aula05_1.OperadorDeCoalescencia();
        aula05_1.OperadorCondicionalNull();

        var aula05_2 = new NullableTypes();
        aula05_2.TiposAnulaveis();
        aula05_2.TiposAnulaveis_T();

        var aula05_3 = new ExcecaoReferenciaNulla();
        aula05_3.ManipulacaoDeNulo();

        Console.ReadKey();
    }


    /// <summary>
    /// <list type="bullet">    
    ///     <item>Classes</item>
    ///     <item>Objetos</item>
    /// </list>
    /// </summary>
    private static void Aula06_25_02_14()
    {
        var aula06_1 = new InstanciaDeClassSimples();
        aula06_1.InstanciaSimples();

        var aula06_2 = new InstanciaDeClassReferenciada();
        aula06_2.InstanciaDeOutraInstancia();
    }


    /// <summary>
    /// <list type="bullet">    
    ///     <item>Métodos</item>    
    ///     <item>Biblioteca de Classe</item>    
    /// </list>
    /// </summary>
    private static void Aula07_25_02_18()
    {
        var aula07 = new Aula07();
        aula07.InstanciaDeClass();
    }


    /// <summary>
    /// <list type="bullet">    
    ///     <item>Sobrecargas</item>    
    ///     <item>Construtores</item>    
    /// </list>
    /// </summary>
    private static void Aula08_25_02_21()
    {
        var aula08 = new Aula08();
        //aula08.InstanciaDeClass1();
        aula08.Sobrecarga2();
    }
}