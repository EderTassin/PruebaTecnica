
function addUser() {
 
  let name = document.getElementById("name").value;
  let lastname = document.getElementById("lastname").value;
  let email = document.getElementById("email").value;

  if (name == "" || lastname == "" || email == "") {
    alert("Por favor, rellene todos los campos");
    return;
  }

  var newUser = {
    name: name,
    lastname: lastname,
    email: email,
  };

  getPersonal();  
}

async function getPersonal() {
  const url = "https://localhost:44311/api/personal";

  debugger;

  const resp = await fetch(url, {
    method: "GET",
    mode: "no-cors", 
    credentials: "same-origin"
  })
    .then(res => res)
    .then(data => {
      console.log(data);
    });

   return resp;
}
