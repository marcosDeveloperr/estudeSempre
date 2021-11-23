import React from "react";

function ComponentB(props)
{
    return(
        <div>Component B que estar dentro do Component A{props.children}</div>
    )
}

export default ComponentB