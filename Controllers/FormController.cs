using System.Globalization;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers {
    public class ContactController : Controller {
        [HttpPost]
        public IActionResult SendEmail(//Contact Details & Address
                                       string FirstName, string LastName, string Company, string Phone, 
                                       string Email, string Street, string Street2, string City, 
                                       string State, string Zipcode,
                                       //Service Details
                                       //Residential
                                       string PropertyType, string[] services, string DeepCleaning, 
                                       string Organization, string NormalCleaning, string MoveInOut, 
                                       string NewPostConstructionCleanUp, string RealEstateStaging, 
                                       string NewBorn, string OtherResidential,
                                       //Commercial
                                       string AirBnb, string OfficeCleaning,
                                       string OtherCommercial,
                                       //Other Services
                                       string Gardening, string PetCare, string GroceryShopping, 
                                       string LaundryServices, string OtherServices,
                                       //Con't Service Info
                                       string Stories, string SquareFootage, string Frequency, 
                                       string AddInfo, 
                                       //Date & Time Info
                                       string AnyTime, string Morning, string Afternoon, 
                                       string Evening, string datepicker, string datepicker2,
                                       //Pet Info
                                       string Dog, string Cat, string OtherPet, string OtherPetDescrip, string SizeBreed, 
                                       string PetName) 
            {
            
            // Convert array to string
            string servicesString = string.Join(", ", services);

            // Construct email body using the submitted form data
            string body = //CONTACT DETAILS & ADDRESS
                          $"CONTACT DETAILS: \n" +
                          $"First Name: {FirstName}\n" +
                          $"Last Name: {LastName}\n" +
                          $"Company: {Company}\n" +
                          $"Phone: {Phone}\n" +
                          $"Email: {Email}\n" +
                          $"Street 1: {Street}\n" +
                          $"Street 2: {Street2}\n" +
                          $"City: {City}\n" +   
                          $"ZIP Code: {Zipcode}\n\n" +
                          //SERVICE DETAILS
                          $"REQUESTED SERVICE DETAILS: \n" +
                          //RESIDENTIAL
                          $"{(!string.IsNullOrEmpty(PropertyType) ? $"Property Type: {PropertyType}\n" : "")}" +
                          //conditional check : if item is not filled out it will not submit an empty the empty field
                          $"{(!string.IsNullOrEmpty(OtherResidential) ? $"Other Residential : {OtherResidential}\n" : "")}" +    
                          $"{(!string.IsNullOrEmpty(OtherCommercial) ? $"Other Commercial: {OtherCommercial}\n" : "")}" +
                          $"{(!string.IsNullOrEmpty(OtherServices) ? $"Other Miscellaneous: {OtherServices}\n" : "")}";


            // RESIDENTIAL checkboxes
            if (DeepCleaning == "checked") body += $"Deep Cleaning: Yes\n";
            if (Organization == "checked") body += $"Organization: Yes\n";
            if (NormalCleaning == "checked") body += $"Normal Cleaning: Yes\n";
            if (MoveInOut == "checked") body += $"Move-in/Move-out: Yes\n";
            if (NewPostConstructionCleanUp == "checked") body += $"New & Post Construction Clean-Up: Yes\n";
            if (RealEstateStaging == "checked") body += $"Real Estate Staging: Yes\n";
            if (NewBorn == "checked") body += $"New Born Arrival Cleaning: Yes\n";

            // COMMERCIAL checkboxes
            if (AirBnb == "checked") body += $"AirBnb's & Vacation Rentals: Yes\n";
            if (OfficeCleaning == "checked") body += $"Office Cleaning: Yes\n";

            // OTHER checkboxes
            if (Gardening == "checked") body += $"Gardening: Yes\n";
            if (PetCare == "checked") body += $"Pet Care: Yes\n";
            if (GroceryShopping == "checked") body += $"Grocery Shopping: Yes\n";
            if (LaundryServices == "checked") body += $"Laundry Services: Yes\n";

            string formattedDatepicker = FormatDate(datepicker);
            string formattedDatepicker2 = FormatDate(datepicker2);

            // ADDITIONAL SERVICE DETAILS
            body += $"\nPROPERTY DETAILS: \n" +
                    $"{(!string.IsNullOrEmpty(Stories) ? $"Number of Stories: {Stories}\n" : "")}" +
                    $"{(!string.IsNullOrEmpty(SquareFootage) ? $"Square Footage: {SquareFootage}\n" : "")}" +
                    $"{(!string.IsNullOrEmpty(Frequency) ? $"Frequency: {Frequency}\n" : "")}" +
                    $"{(!string.IsNullOrEmpty(AddInfo) ? $"Additional Info: {AddInfo}\n" : "")}\n\n" +
                    //DATE & TIME INFO
                    $"TIME OF DAY FOR CLEANING:\n" +
                    $"{(AnyTime == "checked" ? $"Anytime: Yes\n" : "")}" +
                    $"{(Morning == "checked" ? $"Morning: Yes\n" : "")}" +
                    $"{(Afternoon == "checked" ? $"Afternoon: Yes\n" : "")}" +
                    $"{(Evening == "checked" ? $"Evening: Yes\n" : "")}\n\n" +
                    $"REQUESTED APPOINTMENT DAY & TIME:\n" +
                    $"{(!string.IsNullOrEmpty(datepicker) ? $"First Choice: {datepicker}\n" : "")}" +
                    $"{(!string.IsNullOrEmpty(datepicker2) ? $"Second Choice: {datepicker2}\n" : "")}\n\n" +         
                    //PET INFO
                    $"PET INFO:\n" +
                    $"{(Dog == "checked" ? $"Dog: Yes\n" : "")}" +
                    $"{(Cat == "checked" ? $"Cat: Yes\n" : "")}" +
                    $"{(OtherPet == "checked" ? $"Other Pet: Yes\n" : "")}" +
                    $"{(!string.IsNullOrEmpty(OtherPetDescrip) ? $"Other Pet Description: {OtherPetDescrip}\n" : "")}" +
                    $"{(!string.IsNullOrEmpty(SizeBreed) ? $"Size Breed: {SizeBreed}\n" : "")}" +
                    $"{(!string.IsNullOrEmpty(PetName) ? $"Pet Name(s): {PetName}\n" : "")}";


            {
                // Convert checkbox values to "Yes" for checked items
                string deepCleaningChecked = DeepCleaning == "checked" ? "Yes" : "";
                string organizationChecked = Organization == "checked" ? "Yes" : "";
                string normalCleaningChecked = NormalCleaning == "checked" ? "Yes" : "";
                string moveInOutChecked = MoveInOut == "checked" ? "Yes" : "";
                string newPostConstructionCleanUpChecked = NewPostConstructionCleanUp == "checked" ? "Yes" : "";
                string realEstateStagingChecked = RealEstateStaging == "checked" ? "Yes" : "";
                string newBornChecked = NewBorn == "checked" ? "Yes" : "";
                string airBnbChecked = AirBnb == "checked" ? "Yes" : "";
                string officeCleaningChecked = OfficeCleaning == "checked" ? "Yes" : "";
                string gardeningChecked = Gardening == "checked" ? "Yes" : "";
                string petCareChecked = PetCare == "checked" ? "Yes" : "";
                string groceryShoppingChecked = GroceryShopping == "checked" ? "Yes" : "";
                string laundryServicesChecked = LaundryServices == "checked" ? "Yes" : "";
                
            }

            // Email gets sent
            SendEmail(body);

            return RedirectToAction("Index","Home"); 

        }
        private string FormatDate(string date) {
            // Parse the date and format it as desired (month spelled out, day, year)
            DateTime parsedDate;
            if (DateTime.TryParse(date, out parsedDate)) {
                return parsedDate.ToString("MMMM d, yyyy");
            }
            // Return empty string if parsing fails
            return string.Empty;
        }

        private void SendEmail(string body) {
            //string fromMail = "ajscleaning231@gmail.com";
            //string fromPassword = "fknxxzzotqywqbru"; // 2-Step verification app password
            string fromMail = "ajscleaningsvc@gmail.com";
            string fromPassword = "bxjwgpeuwzawqvbz"; // 2-Step verification app password

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "New Contact Form Submission";
            message.To.Add(new MailAddress("ajscleaning231@gmail.com")); 
            message.Body = body;

            using (var smtpClient = new SmtpClient("smtp.gmail.com")) {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(message);
            }
        }
    }
}
