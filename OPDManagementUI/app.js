//UI Constructor
function UI() {}

// reset all the fields on the form UI
UI.prototype.resetFields = function () {
    document.querySelector('#patient-Id').value = '';
    document.querySelector('#date-of-birth').value = '';
    document.querySelector('#first-name').value = '';
    document.querySelector('#middle-name').value = '';
    document.querySelector('#last-name').value = '';
}

// Show alert based on validation. 
UI.prototype.showAlert = function (message, className) {
    // create div 
    const div = document.createElement('div'); 
    // Add classes
    div.className = `alert ${className}`; 
    // Add text
    div.appendChild(document.createTextNode(message)); 
    // Get parent 
    const container = document.querySelector('.container'); 
    // Get form 
    const form = document.querySelector('#patient-detail-form'); 
    // Insert alert 
    container.insertBefore(div, form); 

    // Timeout after 3 seconds 
    setTimeout(function(){
        document.querySelector('.alert').remove(); 
    }, 3000); 
}


// validating the Name field (only accepting string / not accepting symbols)
UI.prototype.validateNumberOnlyField = function (argument) {
    // regular expression to evaluate if an input is NUMBER ONLY. 
    let regex = /^\d+$/; 

    // if argument matches the pattern return argument --> else, return null.  
    if(argument.match(regex)) {
        return (argument);
    }
    else {
        return (null); 
    }
}

// validating the ID field (only accepting numbers / not accepting symbols)
UI.prototype.validateAlphabetOnlyField = function (argument) {
    console.log(argument); 
}

// Adding event listener on submit button: 
document.getElementById('submit').addEventListener('click', function(e){
    // get form values
    const { id, dob, firstName, middleName, lastName } = GetUIValues();  
    
    console.log(id, dob, firstName, middleName, lastName); 
    
    const ui = new UI(); 

    if (id === '' || dob === '' || firstName === '' || lastName === '') {
        ui.showAlert('Please fill in all fields', 'error'); 
    } else {
        ui.showAlert('Patient Added to  the database.', 'success'); 

        // reset fields
        ui.resetFields(); 

        //  display loader image on the UI
        //  Get the container from HTML & display the loader on the page
        let container = document.getElementsByClassName('container'); 
        let imgLoader = document.createElement('style')
            imgLoader.innerHTML = "div { background: url(img/loading.gif);}";  
            
    }
    e.preventDefault(); 
})

function GetUIValues() {
    const id = document.querySelector('#patient-Id').value;
    const dob = document.querySelector('#date-of-birth').value;
    const firstName = document.querySelector('#first-name').value;
    const middleName = document.querySelector('#middle-name').value;
    const lastName = document.querySelector('#last-name').value;
    return { id, dob, firstName, middleName, lastName };
}

/**
 * NavBar JS
 */
function openDrawerMenu(){
    var x = document.getElementById("mainNavBar");
    if (x.className === "navBar"){
      x.className += " responsive";
    } else {
      x.className = "navBar";
    }
  }