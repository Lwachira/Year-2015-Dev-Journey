var painter;
var content;
var winning;//Charlie Sheen 
var turn = 0;
var theCanvas;
var c;
var cxt;
var squareFilled = 0;
var w;
var y;

//Instantiates array

window.onload = function () {
  painter = [];
  content = [];
  winning = [[0, 1, 2], [3, 4, 5], [6, 7, 8], [0, 3, 6], [1, 4, 7], [2, 5, 8], [0, 4, 8], [2, 4, 6]];

  for (var l = 0; l <= 8; l++) {
    painter[l] = false;
    content[l] = '';
  }

};
function canvasClicked(canvasNumber) {

  theCanvas = "canv" + canvasNumber;//Each canv will be stored in this varialbe
  
  c = document.getElementById(theCanvas);
  cxt = c.getContext("2d");
  if (painter[canvasNumber - 1] === false) {

    if (turn % 2 === 0) {
      cxt.fillStyle = "#FF0000";
      cxt.fillRect(0, 0, 300, 300);
    }

    else {
      cxt.fillStyle = "#FFF000";
      cxt.fillRect(0, 0, 300, 300);
    }
    turn++;
    painter[canvasNumber - 1] = true;
    squareFilled++;

    //checkForWinners(content[canvasNumber-1]); 
    
    if (squareFilled === 9) {
      alert("THE GAME IS OVER!");
      location.reload();

    }


  }
  else {

    alert("That block is taken");
  }


}




