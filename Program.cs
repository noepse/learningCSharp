const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

const string quantityTags = "<span>";
const string quantityEndTags = "</span>";

int firstIndexQ = input.IndexOf(quantityTags);
int lastIndexQ = input.IndexOf(quantityEndTags);

int Qlength = lastIndexQ - firstIndexQ - quantityEndTags.Length + 1;

firstIndexQ += quantityTags.Length;

quantity = input.Substring(firstIndexQ, Qlength);

const string outputTags = "<div>";
const string outputEndTags = "</div>";

int firstIndexO = input.IndexOf(outputTags);
int lastIndexO = input.IndexOf(outputEndTags);

int Olength = lastIndexO - firstIndexO - outputEndTags.Length + 1;
firstIndexO += outputTags.Length;

output = input.Substring(firstIndexO, Olength);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output.Replace("&trade;", "&reg;")}");