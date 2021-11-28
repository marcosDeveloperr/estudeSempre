import React from "react";   //preciso dele em todos os arquivos.

function Button(props)
{
    const {name, onClick} = props;

    //agora temos jsx
    return(
        <button onClick={onClick}>{name}</button>
    )
}

export default Button   