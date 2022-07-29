var participantes = [
    {
        nome: "João",
        idade: 17,
        eventoEscolhido: "Evento 1"
    },
    {
        nome: "Vitor",
        idade: 32,
        eventoEscolhido: "Evento 3"
    },
    {
        nome: "Pedro",
        idade: 54,
        eventoEscolhido: "Evento 2"
    },
    {
        nome: "Maria",
        idade: 21,
        eventoEscolhido: "Evento 2"
    },
]

function verifIdade() {
    for (const i in participantes) {
        const idade = participantes[i].idade
        if (idade <= 18) {
            console.log(`O participante, ${participantes[i].nome} não possui a idade necessaria para o evento e foi removido!`)
            participantes.splice(i,1)
        }
    }
}

function listarParticipantes() {
    for (const i of participantes) {
        console.log(`Nome: ${i.nome} | Evento: ${i.eventoEscolhido}`)
    }
}

function verifCadastroPermitido() {
    for (const i of participantes) {
        
        if (contarEvento(i.eventoEscolhido) >= 2) { //Limite teste
            console.log(`O evento ${i.eventoEscolhido} atingiu o seu limite!!`)
        }
    }
}

function contarEvento(evento) {
    const count = participantes.filter(obj => {
    if (obj.eventoEscolhido == evento) {
        return true
    }
    return false
    }).length
    return count
}


verifIdade()
listarParticipantes()
verifCadastroPermitido()