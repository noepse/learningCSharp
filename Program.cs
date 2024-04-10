string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};
string companyDomain = "contoso.com";
string externalDomain = "hayworth.com";

getEmails(corporate, true);
getEmails(external, false);

void getEmails(string[,] names, bool isCorporate){

        for (int i = 0; i < names.GetLength(0); i++) 
{
 string email = corporate[i, 0].Substring(0, 2).ToLower() + corporate[i, 1].ToLower() + "@" + (isCorporate? companyDomain : externalDomain);
 Console.WriteLine(email);
}
    }
