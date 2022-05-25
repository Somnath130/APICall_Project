function SolveCors() {
  const xhttp = new XMLHttpRequest();
  xhttp.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
      document.getElementById("citydata").innerHTML = xhttp.responseText;
    } else {
      console.log("Error");
    }
  };
  xhttp.open("GET", "https://localhost:44398/api/CityData", true);
  xhttp.send();
}

//Insert record
document.getElementById("insertrecord").addEventListener("click", get);

function get() {
  var id = document.getElementById("recordinput").value;

  var url = "https://localhost:44398/api/CityData/" + id;

  fetch(url)
    .then((response) => response.text())

    .then((result) => showRecord(result))

    .catch((error) => console.log("Error!", error));
}

function showRecord(data) {
  document.getElementById("citydata").innerHTML = data;
}
