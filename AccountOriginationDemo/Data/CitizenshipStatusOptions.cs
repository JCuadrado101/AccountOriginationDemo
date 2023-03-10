namespace Account_Origination_Demo.Models;

public class CitizenshipStatusOptions
{
    public List<CitizenshipOptions> ListOfCitizenshipOptions()
    {
        return new List<CitizenshipOptions>
        {
            new CitizenshipOptions("US Citizen", "US Citizen"),
            new CitizenshipOptions("Permanent Resident Alien", "Permanent Resident Alien"),
            new CitizenshipOptions("Nonresident Alien", "Nonresident Alien"),
        };
    }

    public List<ExposedOptions> ListOfExposedOptions()
    {
        return new List<ExposedOptions>
        {
            new ExposedOptions("Yes", "yesExposed"),
            new ExposedOptions("No", "noExposed")
        };
    }

    public List<FamilyExposedOptions> ListOfFamilyExposedOptions()
    {
        return new List<FamilyExposedOptions>
        {
            new FamilyExposedOptions("Yes", "yesFamilyExposed"),
            new FamilyExposedOptions("No", "noFamilyExposed")
        };
    }

    public List<ForeignCountryOptions> ListOfForeignCountryOptions()
    {
        return new List<ForeignCountryOptions>
        {
            new ForeignCountryOptions("Yes", "yesForeignCountryOptions"),
            new ForeignCountryOptions("No", "noForeignCountryOptions")
        };
    }

    public List<CitizenOfForeignCountryOptions> ListOfCitizenOfForeignCountryOptions()
    {
        return new List<CitizenOfForeignCountryOptions>
        {
            new CitizenOfForeignCountryOptions("Yes", "yesCitizenOfForeignCountry"),
            new CitizenOfForeignCountryOptions("No", "noCitizenOfForeignCountry")
        };
    }

    public List<Countries> ListOfForeignCountries()
    {
        return new List<Countries>
        {
            new Countries("", ""),
            new Countries("Afghanistan", "Afghanistan"),
            new Countries("Åland Islands", "Åland Islands"),
            new Countries("Albania", "Albania"),
            new Countries("Algeria", "Algeria"),
            new Countries("American Samoa", "American Samoa"),
            new Countries("Andorra", "Andorra"),
            new Countries("Angola", "Angola"),
            new Countries("Anguilla", "Anguilla"),
            new Countries("Antarctica", "Antarctica"),
            new Countries("Antigua and Barbuda", "Antigua and Barbuda"),
            new Countries("Argentina", "Argentina"),
            new Countries("Armenia", "Armenia"),
            new Countries("Aruba", "Aruba"),
            new Countries("Australia", "Australia"),
            new Countries("Austria", "Austria"),
            new Countries("Azerbaijan", "Azerbaijan"),
            new Countries("Bahamas", "Bahamas"),
            new Countries("Bahrain", "Bahrain"),
            new Countries("Bangladesh", "Bangladesh"),
            new Countries("Barbados", "Barbados"),
            new Countries("Belarus", "Belarus"),
            new Countries("Belgium", "Belgium"),
            new Countries("Belize", "Belize"),
            new Countries("Benin", "Benin"),
            new Countries("Bermuda", "Bermuda"),
            new Countries("Bhutan", "Bhutan"),
            new Countries("Bolivia", "Bolivia"),
            new Countries("Bosnia and Herzegovina", "Bosnia and Herzegovina"),
            new Countries("Botswana", "Botswana"),
            new Countries("Bouvet Island", "Bouvet Island"),
            new Countries("Brazil", "Brazil"),
            new Countries("British Indian Ocean Territory", "British Indian Ocean Territory"),
            new Countries("Brunei Darussalam", "Brunei Darussalam"),
            new Countries("Bulgaria", "Bulgaria"),
            new Countries("Burkina Faso", "Burkina Faso"),
            new Countries("Burundi", "Burundi"),
            new Countries("Cambodia", "Cambodia"),
            new Countries("Cameroon", "Cameroon"),
            new Countries("Canada", "Canada"),
            new Countries("Cape Verde", "Cape Verde"),
            new Countries("Cayman Islands", "Cayman Islands"),
            new Countries("Central African Republic", "Central African Republic"),
            new Countries("Chad", "Chad"),
            new Countries("Chile", "Chile"),
            new Countries("China", "China"),
            new Countries("Christmas Island", "Christmas Island"),
            new Countries("Cocos (Keeling) Islands", "Cocos (Keeling) Islands"),
            new Countries("Colombia", "Colombia"),
            new Countries("Comoros", "Comoros"),
            new Countries("Congo", "Congo"),
            new Countries("Congo, The Democratic Republic of The", "Congo, The Democratic Republic of The"),
            new Countries("Cook Islands", "Cook Islands"),
            new Countries("Costa Rica", "Costa Rica"),
            new Countries("Cote D'ivoire", "Cote D'ivoire"),
            new Countries("Croatia", "Croatia"),
            new Countries("Cuba", "Cuba"),
            new Countries("Cyprus", "Cyprus"),
            new Countries("Czech Republic", "Czech Republic"),
            new Countries("Denmark", "Denmark"),
            new Countries("Djibouti", "Djibouti"),
            new Countries("Dominica", "Dominica"),
            new Countries("Dominican Republic", "Dominican Republic"),
            new Countries("Ecuador", "Ecuador"),
            new Countries("Egypt", "Egypt"),
            new Countries("El Salvador", "El Salvador"),
            new Countries("Equatorial Guinea", "Equatorial Guinea"),
            new Countries("Eritrea", "Eritrea"),
            new Countries("Estonia", "Estonia"),
            new Countries("Ethiopia", "Ethiopia"),
            new Countries("Falkland Islands (Malvinas)", "Falkland Islands (Malvinas"),
            new Countries("Faroe Islands", "Faroe Islands"),
            new Countries("Fiji", "Fiji"),
            new Countries("Finland", "Finland"),
            new Countries("France", "France"),
            new Countries("French Guiana", "French Guiana"),
            new Countries("French Polynesia", "French Polynesia"),
            new Countries("French Southern Territories", "French Southern Territories"),
            new Countries("Gabon", "Gabon"),
            new Countries("Gambia", "Gambia"),
            new Countries("Georgia", "Georgia"),
            new Countries("Germany", "Germany"),
            new Countries("Ghana", "Ghana"),
            new Countries("Gibraltar", "Gibraltar"),
            new Countries("Greece", "Greece"),
            new Countries("Greenland", "Greenland"),
            new Countries("Grenada", "Grenada"),
            new Countries("Guadeloupe", "Guadeloupe"),
            new Countries("Guam", "Guam"),
            new Countries("Guatemala", "Guatemala"),
            new Countries("Guernsey", "Guernsey"),
            new Countries("Guinea", "Guinea"),
            new Countries("Guinea-bissau", "Guinea-bissau"),
            new Countries("Guyana", "Guyana"),
            new Countries("Haiti", "Haiti"),
            new Countries("Heard Island and Mcdonald Islands", "Heard Island and Mcdonald Islands"),
            new Countries("Holy See (Vatican City State)", "Holy See (Vatican City State)"),
            new Countries("Honduras", "Honduras"),
            new Countries("Hong Kong", "Hong Kong"),
            new Countries("Hungary", "Hungary"),
            new Countries("Iceland", "Iceland"),
            new Countries("India", "India"),
            new Countries("Indonesia", "Indonesia"),
            new Countries("Iran, Islamic Republic of", "Iran, Islamic Republic of"),
            new Countries("Iraq", "Iraq"),
            new Countries("Ireland", "Ireland"),
            new Countries("Isle of Man", "Isle of Man"),
            new Countries("Israel", "Israel"),
            new Countries("Italy", "Italy"),
            new Countries("Jamaica", "Jamaica"),
            new Countries("Japan", "Japan"),
            new Countries("Jersey", "Jersey"),
            new Countries("Jordan", "Jordan"),
            new Countries("Kazakhstan", "Kazakhstan"),
            new Countries("Kenya", "Kenya"),
            new Countries("Kiribati", "Kiribati"),
            new Countries("Korea, Democratic People's Republic of", "Korea, Democratic People's Republic of"),
            new Countries("Korea, Republic of", "Korea, Republic of"),
            new Countries("Kuwait", "Kuwait"),
            new Countries("Kyrgyzstan", "Kyrgyzstan"),
            new Countries("Lao People's Democratic Republic", "Lao People's Democratic Republic"),
            new Countries("Latvia", "Latvia"),
            new Countries("Lebanon", "Lebanon"),
            new Countries("Lesotho", "Lesotho"),
            new Countries("Liberia", "Liberia"),
            new Countries("Libyan Arab Jamahiriya", "Libyan Arab Jamahiriya"),
            new Countries("Liechtenstein", "Liechtenstein"),
            new Countries("Lithuania", "Lithuania"),
            new Countries("Luxembourg", "Luxembourg"),
            new Countries("Macao", "Macao"),
            new Countries("Macedonia, The Former Yugoslav Republic of", "Macedonia, The Former Yugoslav Republic of"),
            new Countries("Madagascar", "Madagascar"),
            new Countries("Malawi", "Malawi"),
            new Countries("Malaysia", "Malaysia"),
            new Countries("Maldives", "Maldives"),
            new Countries("Mali", "Mali"),
            new Countries("Malta", "Malta"),
            new Countries("Marshall Islands", "Marshall Islands"),
            new Countries("Martinique", "Martinique"),
            new Countries("Mauritania", "Mauritania"),
            new Countries("Mauritius", "Mauritius"),
            new Countries("Mayotte", "Mayotte"),
            new Countries("Mexico", "Mexico"),
            new Countries("Micronesia, Federated States of", "Micronesia, Federated States of"),
            new Countries("Moldova, Republic of", "Moldova, Republic of"),
            new Countries("Monaco", "Monaco"),
            new Countries("Mongolia", "Mongolia"),
            new Countries("Montenegro", "Montenegro"),
            new Countries("Montserrat", "Montserrat"),
            new Countries("Morocco", "Morocco"),
            new Countries("Mozambique", "Mozambique"),
            new Countries("Myanmar", "Myanmar"),
            new Countries("Namibia", "Namibia"),
            new Countries("Nauru", "Nauru"),
            new Countries("Nepal", "Nepal"),
            new Countries("Netherlands", "Netherlands"),
            new Countries("Netherlands Antilles", "Netherlands Antilles"),
            new Countries("New Caledonia", "New Caledonia"),
            new Countries("New Zealand", "New Zealand"),
            new Countries("Nicaragua", "Nicaragua"),
            new Countries("Niger", "Niger"),
            new Countries("Nigeria", "Nigeria"),
            new Countries("Niue", "Niue"),
            new Countries("Norfolk Island", "Norfolk Island"),
            new Countries("Northern Mariana Islands", "Northern Mariana Islands"),
            new Countries("Norway", "Norway"),
            new Countries("Oman", "Oman"),
            new Countries("Pakistan", "Pakistan"),
            new Countries("Palau", "Palau"),
            new Countries("Palestinian Territory, Occupied", "Palestinian Territory, Occupied"),
            new Countries("Panama", "Panama"),
            new Countries("Papua New Guinea", "Papua New Guinea"),
            new Countries("Paraguay", "Paraguay"),
            new Countries("Peru", "Peru"),
            new Countries("Philippines", "Philippines"),
            new Countries("Pitcairn", "Pitcairn"),
            new Countries("Poland", "Poland"),
            new Countries("Portugal", "Portugal"),
            new Countries("Puerto Rico", "Puerto Rico"),
            new Countries("Qatar", "Qatar"),
            new Countries("Reunion", "Reunion"),
            new Countries("Romania", "Romania"),
            new Countries("Russian Federation", "Russian Federation"),
            new Countries("Rwanda", "Rwanda"),
            new Countries("Saint Helena", "Saint Helena"),
            new Countries("Saint Kitts and Nevis", "Saint Kitts and Nevis"),
            new Countries("Saint Lucia", "Saint Lucia"),
            new Countries("Saint Pierre and Miquelon", "Saint Pierre and Miquelon"),
            new Countries("Saint Vincent and The Grenadines", "Saint Vincent and The Grenadines"),
            new Countries("Samoa", "Samoa"),
            new Countries("San Marino", "San Marino"),
            new Countries("Sao Tome and Principe", "Sao Tome and Principe"),
            new Countries("Saudi Arabia", "Saudi Arabia"),
            new Countries("Senegal", "Senegal"),
            new Countries("Serbia", "Serbia"),
            new Countries("Seychelles", "Seychelles"),
            new Countries("Sierra Leone", "Sierra Leone"),
            new Countries("Singapore", "Singapore"),
            new Countries("Slovakia", "Slovakia"),
            new Countries("Slovenia", "Slovenia"),
            new Countries("Solomon Islands", "Solomon Islands"),
            new Countries("Somalia", "Somalia"),
            new Countries("South Africa", "South Africa"),
            new Countries("South Georgia and The South Sandwich Islands", "South Georgia and The South Sandwich Islands"),
            new Countries("Spain", "Spain"),
            new Countries("Sri Lanka", "Sri Lanka"),
            new Countries("Sudan", "Sudan"),
            new Countries("Suriname", "Suriname"),
            new Countries("Svalbard and Jan Mayen", "Svalbard and Jan Mayen"),
            new Countries("Swaziland", "Swaziland"),
            new Countries("Sweden", "Sweden"),
            new Countries("Switzerland", "Switzerland"),
            new Countries("Syrian Arab Republic", "Syrian Arab Republic"),
            new Countries("Taiwan", "Taiwan"),
            new Countries("Tajikistan", "Tajikistan"),
            new Countries("Tanzania, United Republic of", "Tanzania, United Republic of"),
            new Countries("Thailand", "Thailand"),
            new Countries("Timor-leste", "Timor-leste"),
            new Countries("Togo", "Togo"),
            new Countries("Tokelau", "Tokelau"),
            new Countries("Tonga", "Tonga"),
            new Countries("Trinidad and Tobago", "Trinidad and Tobago"),
            new Countries("Tunisia", "Tunisia"),
            new Countries("Turkey", "Turkey"),
            new Countries("Turkmenistan", "Turkmenistan"),
            new Countries("Turks and Caicos Islands", "Turks and Caicos Islands"),
            new Countries("Tuvalu", "Tuvalu"),
            new Countries("Uganda", "Uganda"),
            new Countries("Ukraine", "Ukraine"),
            new Countries("United Arab Emirates", "United Arab Emirates"),
            new Countries("United Kingdom", "United Kingdom"),
            new Countries("United States", "United States"),
            new Countries("United States Minor Outlying Islands", "United States Minor Outlying Islands"),
            new Countries("Uruguay", "Uruguay"),
            new Countries("Uzbekistan", "Uzbekistan"),
            new Countries("Vanuatu", "Vanuatu"),
            new Countries("Venezuela", "Venezuela"),
            new Countries("Viet Nam", "Viet Nam"),
            new Countries("Virgin Islands, British", "Virgin Islands, British"),
            new Countries("Virgin Islands, U.S.", "Virgin Islands, U.S."),
            new Countries("Wallis and Futuna", "Wallis and Futuna"),
            new Countries("Western Sahara", "Western Sahara"),
            new Countries("Yemen", "Yemen"),
            new Countries("Zambia", "Zambia"),
            new Countries("Zimbabwe", "Zimbabwe")
        };
    }

        public record Countries(string Name, string Values);
        public record CitizenOfForeignCountryOptions(string Name, string Values);
        public record ForeignCountryOptions(string Name, string Values);
        public record FamilyExposedOptions(string Name, string Values);
        public record ExposedOptions(string Name, string Values);
        public record CitizenshipOptions(string Name, string Values);

}

