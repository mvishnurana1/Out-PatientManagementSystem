import { exportValues } from './addPatient';


function UI () {}

// get all UI values
UI.prototype.getUIValues = function()
{
    const houseNum = document.querySelector('#house-number').value, 
          streetName1 = document.querySelector('#street-name-one').value, 
          streetName2 = document.querySelector('#street-name-two').value, 
          suburb = document.querySelector('#suburb').value, 
          postcode = document.querySelector('#postcode').value,   
          state = document.querySelector('#state').value; 

    const { id, dob, firstName, middleName, lastName, visaStatus } = exportValues(); 

          return {
                    id, dob, firstName, middleName, lastName, visaStatus,
                    houseNum, streetName1, streetName2, suburb, postcode, state
                 }; 
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

document.getElementById('continue').addEventListener('click', function(e){
    const ui = new UI(); 

    const {houseNum, streetName1, streetName2, suburb, postcode, state} = ui.getUIValues(); 

    if(houseNum===''|| streetName1===''|| suburb==='' || postcode===''|| state==='null') {
        console.log('ERROR'); 
        ui.showAlert('Please fill in all fields', 'error'); 
    }
    else {
        // get details 
        console.log(id, dob, firstName, middleName, lastName, visaStatus,
            houseNum, streetName1, streetName2, suburb, postcode, state); 
        //console.log(houseNum, streetName1, streetName2, suburb, postcode, state); 
        ui.showAlert('Address Added to  the Patient\'s information.', 'success'); 
    }
    e.preventDefault(); 
}); 