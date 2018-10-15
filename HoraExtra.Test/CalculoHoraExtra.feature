#language: pt-br

Funcionalidade: Cálculo de hora extra
	Para quanto vou ganhar de horas extras
	Enquanto funcionário
	Eu gostaria de calcular o adicional de horas extras

Cenário: Quantidade de 5 horas extras normais
	Dado que estou consumindo o método CalculaHoraExtraNormal
	E preencho o campo 'quantidade' com o valor 5
	Quando executo a aplicação
	Então vejo '102,27'