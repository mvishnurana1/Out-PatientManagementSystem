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
          
          return {houseNum, streetName1, streetName2, suburb, postcode, state}; 
}

UI.prototype.resetUIfields = function() {
    document.querySelector('#house-number').value = '', 
    document.querySelector('#street-name-one').value = '', 
    document.querySelector('#street-name-two').value = '', 
    document.querySelector('#suburb').value = '', 
    document.querySelector('#postcode').value = '',   
    document.querySelector('#state').value = ''; 
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
        console.log(houseNum, streetName1, streetName2, suburb, postcode, state); 
        ui.showAlert('Address Added to  the Patient\'s information.', 'success'); 

        // reset all the UI fields 
        ui.resetUIfields(); 
    }
    e.preventDefault(); 
}); 