import React from 'react'
import { PlayerType } from '../types/player';


interface StatsProps {
     playerState: PlayerType[];
  
}


const Stats : React.FC<StatsProps>= ({playerState}) => {
    const totalPlayers = playerState.length;
  const totalPoints = playerState.reduce((sum, player) => sum + player.score, 0);

  return (
     <table className="stats">
      <tbody>
        <tr>
          <td>Players:</td>
          <td>{totalPlayers}</td>
        </tr>
        <tr>
          <td>Total Points:</td>
          <td>{totalPoints}</td>
        </tr>
      </tbody>
      

    </table>
  )
}

export default Stats




// Request: {"Comments":null,"Items":[{"ItemCode":"ScreenPrint","BaseLineNum":0,"BaseDocEntry":0,"BaseObjType":0,"Desc":"Screenprint","ClientCode":null,"BinCode":"A02A11","BULKBinCode":null,"PICKFACEBinCode":null,"Quantity":2,"UnitPrice":20.0,"UOM":"Each","UOMEntry":0,"isLoaded":false,"isKitParent":false,"SelectedRGA":null,"RGAList":null,"BinList":null,"BaseOrderLineId":5448706}],"PODocEntry":1201241,"CardCode":null}

