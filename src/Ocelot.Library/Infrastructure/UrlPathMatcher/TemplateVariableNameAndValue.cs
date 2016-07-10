namespace Ocelot.Library.Infrastructure.UrlPathMatcher
{
    public class TemplateVariableNameAndValue
    {
        public TemplateVariableNameAndValue(string templateVariableName, string templateVariableValue)
        {
            TemplateVariableName = templateVariableName;
            TemplateVariableValue = templateVariableValue;
        }
        public string TemplateVariableName {get;private set;}
        public string TemplateVariableValue {get;private set;}
    }
}