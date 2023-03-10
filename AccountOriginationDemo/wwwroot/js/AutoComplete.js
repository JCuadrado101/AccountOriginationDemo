let streetNumber;
let street;
let city;
let county;
let state;
let country;
let zipCode;
let address;


let mailstreetNumber;
let mailstreet;
let mailcity;
let mailcounty;
let mailstate;
let mailcountry;
let mailzipCode;
let mailaddress;

function initializeAutocomplete() {
    var input = document.getElementById("autocomplete");
    var autocomplete = new google.maps.places.Autocomplete(input);

    autocomplete.addListener('place_changed', function() {
        var place = autocomplete.getPlace();
        address = place.address_components;

        for (let i = 0; i < address.length; i++) {

            if (address[i].types[0] == "street_number")
            {
                streetNumber = address[i].long_name;
            }

            if (address[i].types[0] == "route")
            {
                street = address[i].long_name;
            }

            if (address[i].types[0] == "locality")
            {
                city = address[i].long_name;
            }

            if (address[i].types[0] == "administrative_area_level_2")
            {
                county = address[i].long_name;
            }

            if (address[i].types[0] == "administrative_area_level_1")
            {
                state = address[i].long_name;
            }

            if (address[i].types[0] == "country")
            {
                country = address[i].long_name;
            }

            if (address[i].types == "postal_code")
            {
                zipCode = address[i].long_name;
            }
        }

    });
}

function initializeAutocompleteMail() {
    var input = document.getElementById("autocompleteMail");
    var autocomplete = new google.maps.places.Autocomplete(input);

    autocomplete.addListener('place_changed', function() {
        var place = autocomplete.getPlace();
        address = place.address_components;

        for (let i = 0; i < address.length; i++) {

            if (address[i].types[0] == "street_number")
            {
                mailstreetNumber = address[i].long_name;
            }

            if (address[i].types[0] == "route")
            {
                mailstreet = address[i].long_name;
            }

            if (address[i].types[0] == "locality")
            {
                mailcity = address[i].long_name;
            }

            if (address[i].types[0] == "administrative_area_level_2")
            {
                mailcounty = address[i].long_name;
            }

            if (address[i].types[0] == "administrative_area_level_1")
            {
                mailstate = address[i].long_name;
            }

            if (address[i].types[0] == "country")
            {
                mailcountry = address[i].long_name;
            }

            if (address[i].types == "postal_code")
            {
                mailzipCode = address[i].long_name;
            }
        }

    });
}

function getAddress() {
    if(streetNumber != undefined)
    {
        return `${streetNumber} ${street}`;
    }
};
function getStreetNumber() {return streetNumber};
function getStreet() {return street};
function getCity() {return city};
function getCounty() {return county};
function getState() {return state};
function getCountry() {return country};
function getZipCode() {return zipCode};

function getMailAddress() {
    if(mailstreetNumber != undefined)
    {
        return `${mailstreetNumber} ${mailstreet}`;
    }
};

function getMailStreetNumber() {return mailstreetNumber};
function getMailStreet() {return mailstreet};
function getMailCity() {return mailcity};
function getMailCounty() {return mailcounty};
function getMailState() {return mailstate};
function getMailCountry() {return mailcountry};
function getMailZipCode() {return mailzipCode};
