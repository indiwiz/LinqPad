<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Bson</Namespace>
  <Namespace>Newtonsoft.Json.Converters</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>Newtonsoft.Json.Schema</Namespace>
  <Namespace>Newtonsoft.Json.Serialization</Namespace>
</Query>

void Main()
{
	var list = JsonConvert.DeserializeObject<List<string>>(GetData());
	var obj = JsonConvert.DeserializeObject<CountryData>(GetObject());
	
	list.Dump();
	obj.Dump();
}

public class CountryData {
	public List<string> Countries { get; set; }
}

string GetObject()
{
	
	return $"{{ 'countries' :  {GetData()} }}";
}

string GetData()
{
	return
	 @" [
    'Afghanistan',
    'Albania',
    'Algeria',
    'Angola',
    'Antigua and Barbuda',
    'Azerbaijan',
    'Argentina',
    'Australia',
    'Austria',
    'The Bahamas',
    'Bahrain',
    'Bangladesh',
    'Armenia',
    'Barbados',
    'Belgium',
    'Bhutan',
    'Bolivia',
    'Bosnia and Herzegovina',
    'Botswana',
    'Brazil',
    'Belize',
    'Solomon Islands',
    'Brunei Darussalam',
    'Bulgaria',
    'Myanmar',
    'Burundi',
    'Belarus',
    'Cambodia',
    'Cameroon',
    'Canada',
    'Cabo Verde',
    'Central African Republic',
    'Sri Lanka',
    'Chad',
    'Chile',
    'China',
    'Colombia',
    'Comoros',
    'Mayotte',
    'Congo',
    'Dem Rep of Congo',
    'Costa Rica',
    'Croatia',
    'Cuba',
    'Cyprus',
    'Czech Republic',
    'Benin',
    'Denmark',
    'Dominican Republic',
    'Ecuador',
    'El Salvador',
    'Equatorial Guinea',
    'Ethiopia',
    'Eritrea',
    'Estonia',
    'Fiji',
    'Finland',
    'France',
    'French Guiana',
    'French Polynesia',
    'Djibouti',
    'Gabon',
    'Georgia',
    'The Gambia',
    'West Bank and Gaza',
    'Germany',
    'Ghana',
    'Kiribati',
    'Greece',
    'Grenada',
    'Guadeloupe',
    'Guam',
    'Guatemala',
    'Guinea',
    'Guyana',
    'Haiti',
    'Honduras',
    'Hong Kong SAR-China',
    'Hungary',
    'Iceland',
    'India',
    'Indonesia',
    'Islamic Republic of Iran',
    'Iraq',
    'Ireland',
    'Israel',
    'Italy',
    'Cote-d-Ivoire',
    'Jamaica',
    'Japan',
    'Kazakhstan',
    'Jordan',
    'Kenya',
    'Dem Peoples Rep of Korea',
    'Rep of Korea',
    'Kuwait',
    'Kyrgyz Republic',
    'Lao PDR',
    'Lebanon',
    'Lesotho',
    'Latvia',
    'Liberia',
    'Libya',
    'Lithuania',
    'Luxembourg',
    'Macao SAR China',
    'Madagascar',
    'Malawi',
    'Malaysia',
    'Maldives',
    'Mali',
    'Malta',
    'Martinique',
    'Mauritania',
    'Mauritius',
    'Mexico',
    'Mongolia',
    'Moldova',
    'Montenegro',
    'Morocco',
    'Mozambique',
    'Oman',
    'Namibia',
    'Nepal',
    'The Netherlands',
    'Curacao',
    'Aruba',
    'New Caledonia',
    'Vanuatu',
    'New Zealand',
    'Nicaragua',
    'Niger',
    'Nigeria',
    'Norway',
    'Federated States of Micronesia',
    'Pakistan',
    'Panama',
    'Papua New Guinea',
    'Paraguay',
    'Peru',
    'Philippines',
    'Poland',
    'Portugal',
    'Guinea-Bissau',
    'Timor-Leste',
    'Puerto Rico',
    'Qatar',
    'Reunion',
    'Romania',
    'Russian Federation',
    'Rwanda',
    'St-Lucia',
    'St-Vincent and the Grenadines',
    'Sao Tome and Principe',
    'Saudi Arabia',
    'Senegal',
    'Serbia',
    'Seychelles',
    'Sierra Leone',
    'Singapore',
    'Slovak Republic',
    'Vietnam',
    'Slovenia',
    'Somalia',
    'South Africa',
    'Zimbabwe',
    'Spain',
    'South Sudan',
    'Sudan',
    'Western Sahara',
    'Suriname',
    'Swaziland',
    'Sweden',
    'Switzerland',
    'Syrian Arab Rep',
    'Tajikistan',
    'Thailand',
    'Togo',
    'Tonga',
    'Trinidad and Tobago',
    'United Arab Emirates',
    'Tunisia',
    'Turkey',
    'Turkmenistan',
    'Uganda',
    'Ukraine',
    'FYR Macedonia',
    'Arab Rep of Egypt',
    'United Kingdom',
    'Channel Islands',
    'Tanzania',
    'United States',
    'US Virgin Islands',
    'Burkina Faso',
    'Uruguay',
    'Uzbekistan',
    'RB-de-Venezuela',
    'Samoa',
    'Rep of Yemen',
    'Zambia',
    'World'
  ]
";
}