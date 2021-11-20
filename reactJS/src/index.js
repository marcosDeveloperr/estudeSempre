import React from "react"
import ReactDOM from "react-dom"
import "./styles.css"

const element = "Olá, Mundo reactJS!"
const element1 = "Começando a minha caminhada."

function App()
{
    return (

        <div>
            {element}
            {element1}
        </div>
    )  
}

const rootElement = document.getElementById("root")
ReactDOM.render(<App/>, rootElement)
