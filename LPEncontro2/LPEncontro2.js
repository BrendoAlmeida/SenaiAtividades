const listaAlunos = [{
    nome: "João",
    notaProva1: 4,
    notaProva2: 3
    },
{
    nome: "Maria",
    notaProva1: 5,
    notaProva2: 5
    },
{
    nome: "Pedro",
    notaProva1: 8,
    notaProva2: 7
    },
{
    nome: "Vitor",
    notaProva1: 9,
    notaProva2: 10
    }
]

for (let index = 0; index < listaAlunos.length; index++) {
    let status = ""
    const media = (listaAlunos[index].notaProva1 + listaAlunos[index].notaProva2) / 2;

    if (media < 4) {
        status = "Reprovado"
    } else if (media >= 4 && media < 6) {
        status = "Recuperação"
    } else if (media >= 6 && media < 8) {
        status = "Aprovado"
    } else if (media >= 8 && media <= 10) {
        status = "Aprovado com méritos"
    }

    console.log(`O aluno ${listaAlunos[index].nome} teve media igual a ${media} e foi ${status}`)
}