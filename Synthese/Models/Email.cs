namespace Synthese.Models;

public class Email
{
  public string? From { get; set; } = "";
  public string? To { get; set; } = "";
  public string? Subject { get; set; } = "";
  public string? Date { get; set; } = "";
}

public class EmailBuilder
{
  private readonly Email _email = new();

  public Email Build()
  {
    return _email;
  }

  public EmailBuilder WithFrom(string from)
  {
    _email.From = from;
    return this;
  }

  public EmailBuilder WithTo(string to)
  {
    _email.To = to;
    return this;
  }

  public EmailBuilder WithSubject(string subject)
  {
    _email.Subject = subject;
    return this;
  }

  public EmailBuilder WithDate(string date)
  {
    _email.Date = date;
    return this;
  }
}