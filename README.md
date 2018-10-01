**Frends.Task.Attributes package has been deprecated, and all new task versions should use the new attributes from System.ComponentModel.DataAnnotations.**

# Frends.Tasks.Attributes

Custom decorator attributes for FRENDS task parameters. Allows you to have e.g. conditional fields or tabbed inputs.

## ConditionalDisplayAttribute

Shows the parameter if another property has the expected value

Parameters:
- *OtherProperty* - Name of property whose value to check
- *ConditionValue* - If matches the property value, the parameter is displayed

Example usage:

    public Enum ParameterChoice
    {
        Parameter,
        Parameter2
    }

    public class ParameterGroup
    {
        public ParameterChoice WhichParameterToShow { get; set; }

        [ConditionalDisplay(nameof(WhichParameterToShow), ParameterChoice.Parameter)]
        public string Parameter { get; set; }

        [ConditionalDisplay(nameof(WhichParameterToShow), ParameterChoice.Parameter2)] 
        public string Parameter2 { get; set; }
    }

## DefaultDisplayType

Sets how the editor field should be shown by default, can be any of the following:

    Text
    MultilineText
    Json
    Xml
    Sql
    Expression

For example, the for a `byte[]` parameter, the following would render the editor field by default in expression mode instead of the array editor:

    [DefaultDisplayType(DisplayType.Expression)]
    public byte[] Bytes { get; set; }

## CustomDisplay

Allows grouping of parameters to tabs or under expanders. Value can be one of:

    Default
    Tab
    Expander

For example, the following will render the `input` and `options` parameters for the task in different tabs:

    public static async Task<SampleTaskResult> Sample(
        [CustomDisplay(DisplayOption.Tab)] SampleInput input, 
        [CustomDisplay(DisplayOption.Tab)] SampleOptions options)
    {
        ...
