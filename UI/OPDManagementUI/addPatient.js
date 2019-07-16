function UI() {}

// get all UI values
function GetUIValues() {
    const id = document.querySelector('#patient-Id').value;
    const dob = document.querySelector('#date-of-birth').value;
    const firstName = document.querySelector('#first-name').value;
    const middleName = document.querySelector('#middle-name').value;
    const lastName = document.querySelector('#last-name').value;
    const visaStatus = document.querySelector('#visa-status').value;

    return { id, dob, firstName, middleName, lastName, visaStatus };
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

/**
 * The function hides the HTML form
 * Displays the animation
 * loads the next page after 2 second delay
 */ 
function animationToLoadNextPage() {
    document.getElementsByTagName('body')[0].style.visibility = 'hidden'; 
    document.getElementsByTagName('body')[0].className = 'loader_div';

    window.setTimeout(function() {
        window.location.href = "add-patient-info.html";
    }, 1000); 
}

document.getElementById('continue').addEventListener('click', eventHandler); 

function eventHandler(e) {
    const ui = new UI(); 
    
    // get form values
    const { id, dob, firstName, middleName, lastName, visaStatus } = GetUIValues();  
    
    console.log(id, dob, firstName, middleName, lastName, visaStatus); 
    
    if (id === '' || dob === '' || firstName === '' || 
            lastName === '' || visaStatus === 'null') {
        ui.showAlert('Please fill in all fields', 'error'); 

    } else {

        let newId = id,
              newDob = dob, 
              first_Name = firstName, 
              middle_Name = middleName, 
              last_Name = lastName, 
              visa_Status = visaStatus; 

        exportValues(newId, newDob, first_Name, middle_Name, last_Name, visa_Status); 
        animationToLoadNextPage(); 
    }
    e.preventDefault();
}

export default function exportValues(id, dob, firstName, middleName, lastName, visaStatus) {
    console.log('printing export values: '+  id, dob, firstName, middleName, lastName, visaStatus ); 

    return { id, dob, firstName, middleName, lastName, visaStatus }; 
}

export { exportValues }; 