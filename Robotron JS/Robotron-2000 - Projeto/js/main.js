// // Aqui será manipulado o array de todos os botões
// const controle = document.querySelectorAll("[data-controle]")
// const estatisticas = document.querySelectorAll("[data-estatistica]")
// const pecas = {
//     "bracos": {
//         "forca": 29,
//         "poder": 35,
//         "energia": -21,
//         "velocidade": -5
//     },
//     "blindagem": {
//         "forca": 41,
//         "poder": 20,
//         "energia": 0,
//         "velocidade": -20
//     },
//     "nucleos": {
//         "forca": 0,
//         "poder": 7,
//         "energia": 48,
//         "velocidade": -4
//     },
//     "pernas": {
//         "forca": 27,
//         "poder": 21,
//         "energia": -32,
//         "velocidade": 43
//     },
//     "foguetes": {
//         "forca": 0,
//         "poder": 28,
//         "energia": 0,
//         "velocidade": -2
//     }
// }

// // O array tem uma função própria, que é o forEach 
// controle.forEach((elemento) => {
//     elemento.addEventListener("click", (evento) => {
// // Estamos enviando 2 blcos de informação da função manipular Dados, um é o operação (pai de operação) 
// //e o outro é o controle (pai de controle)
//         manipulaDados(evento.target.dataset.controle, evento.target.parentNode)
//         atualizaEstatisticas(evento.target.dataset.peca)
//     })
// })

// // O arrow function serve para economizarmos a escrita da função, identificamos como função anonima 
// // somar.addEventListener("click", () => {manipulaDados("somar")})

// // subtrair.addEventListener("click", (evento) => {manipulaDados("subtrair")})

// function manipulaDados(operacao, controle) {
//     const peca = controle.querySelector("[data-contador]")

//     if(operacao === "-") {
//         peca.value = parseInt(peca.value) - 1
//     } else {
//         peca.value = parseInt(peca.value) + 1
//     }
// } 

// function atualizaEstatisticas(peca) {
//     estatisticas.forEach( (elemento) => {
//         elemento.textContent = parseInt(elemento.textContent) + pecas[peca][elemento.dataset.estatistica]
//     })
// }

const controle = document.querySelectorAll("[data-controle]")
const estatistica = document.querySelectorAll("[data-estatistica]")

const pecas = {
    "bracos": {
        "forca": 29,
        "poder": 35,
        "energia": -21,
        "velocidade": -5
    },

    "blindagem": {
        "forca": 41,
        "poder": 20,
        "energia": 0,
        "velocidade": -20
    },
    "nucleos":{
        "forca": 0,
        "poder": 7,
        "energia": 48,
        "velocidade": -24
    },
    "pernas":{
        "forca": 27,
        "poder": 21,
        "energia": -32,
        "velocidade": 42
    },
    "foguetes":{
        "forca": 0,
        "poder": 28,
        "energia": 0,
        "velocidade": -2
    }
}

controle.forEach( (elemento) => {
    elemento.addEventListener('click', (evento) => {
        manipulaDados(evento.target.textContent, evento.target.parentNode)
        atualizaEstatistica(evento.target.dataset.peca)
    })
})

function manipulaDados(operacao, controle) {
    const peca = controle.querySelector("[data-contador]")

    if(operacao === "-") {
        peca.value = parseInd(peca.value) - 1
    } else {
        peca.value = parseInt(peca.value) + 1
    }
}

function atualizaEstatistica(peca) {
    estatistica.forEach( (elemento ) => {
        elemento.textContent = parseInt(elemento.textContent) + pecas[peca][elemento.dataset.estatistica]
    })
}
