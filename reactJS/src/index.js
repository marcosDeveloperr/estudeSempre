import React from "react"
import ReactDOM from "react-dom"
import "./styles.css"
import Button from "./Button"
import ComponentA from "./ComponentA"
import ComponentB from "./ComponentB"
const element = "Olá, Mundo reactJS!"
const element1 = "Começando a minha caminhada."

function soma(a,b)
{
   alert(a + b);
}

function App()
{
    return (

        <div className="App">
            {element}
            {element1}
            <div>
                <Button onclick={() => soma(12,1)} name="Marcos Flamenguista"/>  
                <ComponentA>
                    <ComponentB>
                        <Button onclick={()=>soma(15,3)} name="Outro Button"/>
                    </ComponentB>
                </ComponentA> 
            </div>
        </div>
    )   
}

const rootElement = document.getElementById("root")
ReactDOM.render(<App />, rootElement)
