using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BCS.JobProcessing.Host.Models;
using NuGet.Common;
using Newtonsoft.Json;



// The ASP.NET Core templates for: 
// Controllers with views include [action] in the route template.
// API controllers don't include [action] in the route template.
// When the [action] token isn't in the route template, the action name (method name) isn't included in the
// endpoint. That is, the action's associated method name isn't used in the matching route.

namespace BCS.JobProcessing.Host.Controllers
{
    [Route("api/ODS")]
    [ApiController]
    public class ODSController : ControllerBase // Defines the ODSController class, which inherits from ControllerBase.
    {
        private readonly OdsRev2025Context _context; // Declares a private readonly field for the database context.

        public ODSController(OdsRev2025Context context) // Constructor that initializes the database context.
        {
            _context = context; // Assigns the database context to the private readonly field.
        }

        // GET: api/ODS
        [HttpGet] // Indicates that this action handles HTTP GET requests.
        public async Task<List<ValidateGutOdsPremiumDataDTO>> GetValidateGutOdsPremiumDataDTO() // Asynchronous method to get all ValidateGutOdsPremiumDataDTO records.
        {
            List<ValidateGutOdsPremiumDataDTO> results = new List<ValidateGutOdsPremiumDataDTO>(); // Initializes an empty list to store the results.

            results = await _context.ValidateGutOdsPremiumDataDTO.ToListAsync(); // Retrieves all records from the database asynchronously.

            var jsonResult = JsonConvert.SerializeObject(results); // Serializes the results to JSON (not used further).

            return results; // Returns the list of results.
        }

        // GET: api/ODS/5
        [HttpGet("{id}")] // Indicates that this action handles HTTP GET requests with an ID parameter.
        public async Task<ActionResult<ValidateGutOdsPremiumDataDTO>> GetValidateGutOdsPremiumDataDTO(long id) // Asynchronous method to get a specific ValidateGutOdsPremiumDataDTO record by ID.
        {
            var validateGutOdsPremiumDataDTO = await _context.ValidateGutOdsPremiumDataDTO.FindAsync(id); // Finds the record with the specified ID asynchronously.

            if (validateGutOdsPremiumDataDTO == null) // Checks if the record was not found.
            {
                return NotFound(); // Returns a 404 Not Found response.
            }

            return validateGutOdsPremiumDataDTO; // Returns the found record.
        }

        [HttpPut("{id}")] // Indicates that this action handles HTTP PUT requests with an ID parameter.
        public async Task<IActionResult> PutValidateGutOdsPremiumDataDTO(long id, ValidateGutOdsPremiumDataDTO validateGutOdsPremiumDataDTO) // Asynchronous method to update a specific ValidateGutOdsPremiumDataDTO record by ID.
        {
            if (id != validateGutOdsPremiumDataDTO.GutOdsPremiumId) // Checks if the ID in the URL does not match the ID in the request body.
            {
                return BadRequest(); // Returns a 400 Bad Request response.
            }

            _context.Entry(validateGutOdsPremiumDataDTO).State = EntityState.Modified; // Marks the record as modified in the database context.

            try
            {
                await _context.SaveChangesAsync(); // Saves the changes to the database asynchronously.
            }
            catch (DbUpdateConcurrencyException) // Catches any concurrency exceptions that occur during the save operation.
            {
                if (!ValidateGutOdsPremiumDataDTOExists(id)) // Checks if the record no longer exists in the database.
                {
                    return NotFound(); // Returns a 404 Not Found response.
                }
                else
                {
                    throw; // Rethrows the exception if it is not a concurrency issue.
                }
            }

            return NoContent(); // Returns a 204 No Content response.
        }

        // POST: api/ODS
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost] // Indicates that this action handles HTTP POST requests.
        public async Task<ActionResult<ValidateGutOdsPremiumDataDTO>> PostValidateGutOdsPremiumDataDTO(ValidateGutOdsPremiumDataDTO validateGutOdsPremiumDataDTO) // Asynchronous method to create a new ValidateGutOdsPremiumDataDTO record.
        {
            _context.ValidateGutOdsPremiumDataDTO.Add(validateGutOdsPremiumDataDTO); // Adds the new record to the database context.
            await _context.SaveChangesAsync(); // Saves the changes to the database asynchronously.

            return CreatedAtAction(nameof(GetValidateGutOdsPremiumDataDTO), new { id = validateGutOdsPremiumDataDTO.GutOdsPremiumId }, validateGutOdsPremiumDataDTO); // Returns a 201 Created response with the location of the new record.
        }

        // DELETE: api/ODS/5
        [HttpDelete("{id}")] // Indicates that this action handles HTTP DELETE requests with an ID parameter.
        public async Task<IActionResult> DeleteValidateGutOdsPremiumDataDTO(long id) // Asynchronous method to delete a specific ValidateGutOdsPremiumDataDTO record by ID.
        {
            var validateGutOdsPremiumDataDTO = await _context.ValidateGutOdsPremiumDataDTO.FindAsync(id); // Finds the record with the specified ID asynchronously.
            if (validateGutOdsPremiumDataDTO == null) // Checks if the record was not found.
            {
                return NotFound(); // Returns a 404 Not Found response.
            }

            _context.ValidateGutOdsPremiumDataDTO.Remove(validateGutOdsPremiumDataDTO); // Removes the record from the database context.
            await _context.SaveChangesAsync(); // Saves the changes to the database asynchronously.

            return NoContent(); // Returns a 204 No Content response.
        }

        private bool ValidateGutOdsPremiumDataDTOExists(long id) // Helper method to check if a ValidateGutOdsPremiumDataDTO record exists by ID.
        {
            return _context.ValidateGutOdsPremiumDataDTO.Any(e => e.GutOdsPremiumId == id); // Returns true if the record exists, otherwise false.
        }
    }
}
