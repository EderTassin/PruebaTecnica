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
      email: email
    };

    alert("Gracias ",newUser.name); 
    
  }
  