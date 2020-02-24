Teste 01 (Aritméticos e Lógicos) - Console application - 

Calculadora com as principais operações, e um simples menu. Dica: Explore a classe console.

Descreva as principais funções e o que encontramos do ponto de vista macro (Só o que contém, de forma mais abrangente)
nos namespaces e destaque no mínimo 03 classes que podemos trabalhar em cada um deles: System.Text, System.Threading,
System.Linq, System.IO, System.Data, System.Security, System.Diagnostics, System.Runtime, System.Globalization, 
System.Buffers;
Do ponto de vista macro, encontramos os namespaces using que são indispensáveis para a criação de um código, porque ele 
possui as principais classes para tal.
 - System.IO: possui classes que são capazes de criar e ler arquivos em um determinado diretório. 
 - System.Linq: possui classes capazes de iterar sobre objetos do tipo IEnumerable<>.
 - System.Globalization: possui classes capazes de formatar os dados para a cultura de um determinado país, como: moeda, data, hora.

Trabalhando com Parâmetros: de entrada, de saida, objeto parâmetro, funções como pârametros, refletindo sobre efeitos 
colaterais (Imutabilidade e porque é importante).

O que são e para que servem Interfaces, e o que são Generics?
 - Interfaces servem para criar contratos, dessa forma a classe que implementar a interface terá que obrigatoriamente implementar 
 os seus métodos. Generis é um tipo, qualquer, de objeto que será definido pelo programador.

Coleções 01 (System.Collections) - Arrays, Dictionary, SortedDictionary, HashSet, Listas, SortedList, Queues e Stack. 
Quais são as diferenças entre esses tipos, tem que métodos distintos, qual o uso indicado?
Classes associativas, como? Dictionary, sortedDictionary e SortedList são de fácil acesso, porque possuem uma chave para tal. Os 
Dictionarys são mais usados e 
 - Array - Definimos o tamanho de um Array na sua inicialização e para percorrer um array, precisamos conhecer o seu índice.
 É custoso aumentar o tamanho de um array, precisamos copiar todos os seus dados para um novo array de maior tamanho.
 - D