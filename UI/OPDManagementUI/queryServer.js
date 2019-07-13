URL_ENDPOINT = "http://localhost:32691/OPD";

function getPatient(id, callback, errorCallback){
    fetch(`${URL_ENDPOINT}`)
        .then(dat=>dat.json())
        .then(obj=>callback(obj))
        .catch(e=>errorCallback(e))
}

document.getElementById("submit").addEventListener("click", searchPatient);
console.log(document.getElementById("submit"))
console.log("bound")

function searchPatient(e){
    e.preventDefault();
    let id = document.getElementById("patient-id").value;
    console.log("Triggered")
    
     getPatient(id, patients=>{
        console.log(JSON.stringify(patients));
        
        let outputTable = $('#patient-detail-list'); 
        outputTable.empty(); 
         
        patients.forEach(patient => {
        
            outputTable.append(`<tr><td>${patient.PatientID}</td>
            <td>${patient.FirstName}</td>
            <td>${patient.LastName}</td>
            <td>${patient.DateOfBirth}</td>
            <td>${patient.Gender}</td></tr>`)
        });
        
    },
    e=>{
        console.log(e); 
    });
}
