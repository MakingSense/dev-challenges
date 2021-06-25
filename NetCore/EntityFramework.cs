public Country GetCountryByCode(string countryCode)
{
    var country = _dbContext
        .Countries
        .Where(c => c.CountryCode == countryCode);
        
    return country;
}