﻿using Aula_01;
using Aula_02;
using Aula_03;
using Aula_04;
using Aula_05;
using Aula_06;
using Aula_07;
using Aula_08;
using Aula_09;
using Aula_10;
using Aula_11;
using Aula_12;
using Aula_13;
using Aula_14;
using Aula_15;
using Aula_16;
using Aula_17;
using Aula_18;
using Aula_19;
using Aula_20;
using Aula_21;
using Aula_22;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Para executar a aula desejada, basta descomentar a linha correspondente
        //Aula01();
        //Aula02();
        //Aula03();
        //Aula04();
        //Aula05();
        //Aula06();
        //Aula07();
        //Aula08();
        //Aula09();
        //Aula10();
        //Aula11();
        //Aula12();
        //Aula13();
        //Aula14();
        Aula15();
        //Aula16();
        //Aula17();
        //Aula18();
        //Aula19();
        //Aula20();
    }


    /// <summary>
    /// <list type="bullet">    
    ///     <item>Introdução ao .Net</item>
    ///     <item>Componentes</item>
    ///     <item>Visual Studio Community 2022</item>
    ///     <item>Criando soluções e projetos</item>
    /// </list>
    /// </summary>
    private static void Aula01()
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
    private static void Aula02()
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
    private static void Aula03()
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
    private static void Aula04()
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
    private static void Aula05()
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
    private static void Aula06()
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
    private static void Aula07()
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
    private static void Aula08()
    {
        var aula08 = new Aula08();
        aula08.Sobrecarga1();
        aula08.Sobrecarga2();
        aula08.Construtores();
    }


    /// <summary>
    /// <list type="bullet">    
    ///     <item>Coleções (Listas Genéricas <T>)</item>    
    /// </list>
    /// </summary>
    private static void Aula09()
    {
        var aula09 = new Aula09();
        aula09.ListMethodAdd_AddRange();
        aula09.IteracaoForEach();
        aula09.CapacityExplicacao();
    }


    /// <summary>
    /// <list type="bullet">    
    ///     <item>static class</item>
    ///     <item>partial class</item>
    ///     <item>Herança</item>
    /// </list>
    /// </summary>
    private static void Aula10()
    {
        var aula10 = new Aula10();
        aula10.StaticClass();
        aula10.UsoExtensionMethods();
    }


    /// <summary>
    /// Herança
    /// <list type="bullet">    
    ///     <item>sealed class</item>
    ///     <item>construtores</item>
    ///     <item>base class</item>
    ///     <item>base class</item>
    /// </list>
    /// Abstract Calss
    /// </summary>
    private static void Aula11()
    {
        var aula11 = new Aula11();
        aula11.UsoHeranca();
    }


    /// <summary>    
    /// <list type="bullet">    
    ///     <item>Exceções Personalizadas</item>
    ///     <item>Override ToString</item>
    ///     <item>Override Equals</item>
    ///     <item>Override HasCode</item>
    ///     <item>HasSet</item>
    ///     <item>Virtual</item>
    /// </list>
    /// </summary>
    private static void Aula12()
    {
        var aula12 = new Aula12();
        aula12.Start();
    }


    /// <summary>    
    /// <list type="bullet">        
    ///     <item>Interface</item>
    ///     <item>IComparable</item>
    ///     <item>CompareTo</item>
    /// </list>
    /// </summary>
    private static void Aula13()
    {
        var aula13 = new Aula13();
        aula13.Start();
    }


    /// <summary>    
    /// <list type="bullet">            
    ///     <item>struct</item>
    ///     <item>records</item>
    ///     <item>Imutabilidade</item>
    /// </list>
    /// </summary>
    private static void Aula14()
    {
        var aula14 = new Aula14();
        aula14.Start();
    }


    /// <summary>    
    /// <list type="bullet">            
    ///     <item>System.IO</item>    
    ///     <item>Manipulação de Arquivos</item>
    /// </list>
    /// </summary>
    private static void Aula15()
    {
        var aula15 = new Aula15();
        aula15.Start();
    }
}