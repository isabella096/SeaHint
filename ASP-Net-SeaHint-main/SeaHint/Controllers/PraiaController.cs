using SeaHint.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace SeaHint.Controllers
{
    public class PraiaController : Controller
    {
        public List<Informacao> Curiosidade { get; private set; }

        public IActionResult PraiadeMaresias()
        {

            var maresias = new List<Praia>
            {
                new Praia
                {
                    nome = "Praia de Maresias",
                    descricao ="Maresias é a praia responsável por grande parte dos turista que chegam ao Litoral Norte de São Paulo. Famosa pelas boas ondas e por ter revelado grandes nomes do surfe mundial, Maresias é muito mais que apenas uma praia. De tão importante para a região de São Sebastião, há quem chegue por lá pensando que Maresias é a cidade de fato. Um dos principais destinos entre as praias do Brasil, Maresias atrai pela boa infraestrutura, grande número de pousadas e fartura de restaurantes. Sem falar na balada e vida noturna, uma das mais famosas do país. \r\n        Aproveite um feriado prolongado ou as merecidas férias para curtir Maresias. Acredite! Não faltará o que fazer em Maresias durante os seus dias de descanso por lá.\r\n\r\n            Maresias e outras praias de São Sebastião estão entre as mais belas praias de São Paulo. Com mais de trinta faixas de areia para dias de descanso, São Sebastião oferece praia para todos os gostos e desejos. Há praias desertas, praias de ilhas, praias com rio, praias para surfe e praias com vista para o intenso verde da Serra do Mar. Tem praia com muito agito – como a Praia de Maresias e a Praia de Juquehy – e praia que é só calmaria, como a lindíssima Praia de Calhetas. Certamente Maresias e as outras praias de São Sebastião irão se encaixar perfeitamente no seu desejo de férias ou em uma viagem rápida de final de semana. Se você procura um lugar para esfriar a cabeça e relaxar quando a quarentena passar, Maresias pode ser o seu lugar!",
                   
                  

                }
            };
            Informacao informacao = new Informacao();
            ViewBag.curiosidade1 = informacao.Texto = "Curiosade: Um lugar que você não pode deixar de conhecer na Praia de Maresias é o Beco da Mulher Maravilha. Ele fica na entrada 8 da praia e se trata de um corredor cheio de grafites super bonitos. É um cantinho para lá de instagramável para fazer aquela foto de recordação da sua viagem a Maresias. Seu nome é uma alusão ao Beco do Batman, localizado na cidade de São Paulo.";






            return View(maresias);

          



        }
        public IActionResult PraiaBranca()
        {

            var branca = new List<Praia>
            {
                new Praia
                {
                    nome = "Praia Branca",
                    descricao ="Paradisíaca e de acesso peculiar, a Prainha Branca, situada no litoral de São Paulo, é um refúgio natural que atrai aventureiros em busca de tranquilidade e belezas naturais.\r\n\r\n            Desconhecida por muitos, a Prainha Branca, no litoral de São Paulo, esconde-se como um oásis pouco explorado. Longe das aglomerações e da rotina urbana, esta pequena enseada reserva-se para os poucos que desviam das trilhas convencionais. No coração de uma área de proteção ambiental, a Prainha Branca é uma pérola natural, onde a preservação fala mais alto do que qualquer alarde.\r\n            \r\n            O caminho até esse refúgio é um capítulo à parte. Sem estradas pavimentadas, o acesso à Prainha Branca é marcado por trilhas sinuosas e opções de barco a partir da Praia do Guarujá. O desafio para chegar à areia branca é uma espécie de seleção natural para aqueles que procuram escapar do convencional. A vegetação densa da Mata Atlântica e os ventos salgados do oceano são os únicos guias nessa jornada.\r\n            A exclusividade do acesso contribui para manter a Prainha Branca como um segredo bem guardado. À medida que a cidade e suas praias mais populares se movimentam, esse refúgio permanece intocado e resguardado. Longe dos holofotes, ela sussurra aos visitantes sobre a beleza crua e a paz que se esconde em meio à natureza preservada.",
             
                }
            };
            Informacao informacao = new Informacao();
            ViewBag.curiosidade2 = informacao.Texto = "Curiosade: A praia Branca Guarujá/Bertioga SP ou “Prainha Branca” como é conhecida, não só é uma das mais belas da região como também é uma das Praias do Guarujá mais procurada, principalmente por jovens e a galera mais “roots” que curtem camping e um contato mais próximo com a natureza.O mar da prainha branca é bem agitado, logo, tome muito cuidado ao entrar no mar. As extremidades da praia são com águas mais calmas, excelentes para tomar um banho de mar.";


            ViewBag.nome = branca[0].nome;
            return View(branca);

           
           

        }
        public IActionResult PraiaDomingo()
        {

            var domingo = new List<Praia>
            {
                new Praia
                {
                    nome = "Praia Domingo Dias",
                    descricao ="A Praia Domingas Dias, vizinha à Praia do Lázaro, atrai quem busca uma praia mais tranquila. O mar é calmo e forma uma límpida e deliciosa piscina, principalmente no canto esquerdo. É um cenário maravilhoso e cercado por muito verde. Suba nas pedras para observar a paisagem e não deixe de percorrer toda a faixa de areia, que é bem compacta e boa para a prática de esportes. A água também é convidativa a passeios de caiaque e stand up. Aproveite o visual! Não há restaurantes e quiosques fixos na Praia de Domingas Dias, mas algumas barraquinhas ajudam a aplacar a fome e a sede.\r\n\r\n            As praias de Domingas Dias, Lázaro e Sununga formam um trio excelente para ser visitado em um mesmo dia. Lázaro está no centro, Sununga fica à esquerda e Domingas Dias, à direita. Uma caminhada curta leva de uma à outra, o que permite escolher a praia favorita para ficar mais tempo sem precisar tirar o carro do lugar.\r\n        </p>\r\n",
                 
                }
            };

            Informacao informacao = new Informacao();
            ViewBag.curiosidade3 = informacao.Texto = "Curiosade: Um lugar que você não pode deixar de conhecer na Praia de Maresias é o Beco da Mulher Maravilha. Ele fica na entrada 8 da praia e se trata de um corredor cheio de grafites super bonitos. É um cantinho para lá de instagramável para fazer aquela foto de recordação da sua viagem a Maresias. Seu nome é uma alusão ao Beco do Batman, localizado na cidade de São Paulo.";

            ViewBag.nome = domingo[0].nome;
            return View(domingo);

        }
    }
}
    
