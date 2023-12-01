﻿define("ServiceParameterPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ParameterCaption: "Name",
		ParameterName: "Code in Creatio",
		ParameterCode: "Code in method",
		ParameterIsArray: "Is array",
		ParameterDataType: "Data type",
		ParameterType: "Parameter type",
		WrongNameMessage: "Invalid value. Use symbols: a-z, A-Z, 0-9. \u003C/br\u003E Symbol: 0-9 cannot be first.",
		WrongCodeMessage: "Wrong code format",
		WarningMustSetIsObjectText: "You can select Object type only if Is Array attribute set",
		WrongPrefixMessage: "Code of the method must contain prefix \u0022{0}\u0022",
		CodeUNDEFINEDCaption: "Undefined",
		CodeBODYCaption: "Path to element (JSONPath)",
		CodeURL_SEGMENTCaption: "Code in address",
		CodeQUERY_STRINGCaption: "Code in query",
		CodeHTTP_HEADERCaption: "Header code",
		CodeCOOKIECaption: "Cookie code",
		WarningNoBodyParameterForGetText: "GET Method cannot have body parameters",
		DuplicateNameMessage: "Parameter with this code already exists.",
		PathHintForBodyType: "For example, $.parameterName",
		CancelButtonCaption: "Cancel",
		IsArrayHint: "Array parameter value cannot be set in \u0022Call web service\u0022 element in process designer. Please use \u0022Script task\u0022 element instead. Parameter with data type \u0022Object\u0022 must be an array",
		DataValueTypeHint: "Parameter with nested elements must have \u0022Object\u0022 data type",
		CodeHint: "Used by developers for interacting with the web service in Creatio source code",
		ObjectDataValueTypeHint: "Parameter with nested elements must have \u0022Object\u0022 data type",
		PathHintBodyPath: "Read more about creating requests",
		PathHintHeaderPath: "Header with the following code will be added to the HTTP request headers",
		PathHintQueryPath: "Request parameters will be specified in the complete call address in the following format: \u0022?paramCode=value\u0022",
		PathHintUriPath: "Must match the code in the method address in curly braces {}",
		PathHintCookiePath: "Cookie with the following code will be added to the HTTP request",
		SaveNewParameterButtonCaption: "OK",
		ParameterIsRequired: "Required",
		IsRequiredHint: "Select this checkbox to make this a required parameter in the Process Designer. The checkbox cannot be selected if the \u0022Default value\u0022 field is filled in. Also, it must be selected or \u0022Default value\u0022 field must be populated for parameter of the \u0022Method address\u0022 type.",
		SequenceElementNameCaption: "Sequence element name",
		SequenceObjectElementNameTip: "XML element name of every direct child element in array. For example, it will be \u0022book\u0022 in \u0022Books\u0022 array:\n\u0026#60;Books\u0026#62;\n    \u0026#60;book\u0026#62;\n        \u0026#60;title\u0026#62;Book name 1\u0026#60;/title\u0026#62;\n        \u0026#60;author\u0026#62;Author 1\u0026#60;/author\u0026#62;\n    \u0026#60;/book\u0026#62;\n    \u0026#60;book\u0026#62;\n        \u0026#60;title\u0026#62;Book name 2\u0026#60;/title\u0026#62;\n        \u0026#60;author\u0026#62;Author 2\u0026#60;/author\u0026#62;\n    \u0026#60;/book\u0026#62;\n    \u0026#60;book\u0026#62;\n        \u0026#60;title\u0026#62;Book name 3\u0026#60;/title\u0026#62;\n        \u0026#60;author\u0026#62;Author 3\u0026#60;/author\u0026#62;\n    \u0026#60;/book\u0026#62;\n\u0026#60;/Books\u0026#62;",
		SequenceElementNameTip: "XML element name of every direct child element in array. For example, it will be \u0022title\u0022 in \u0022Books\u0022 array:\n\u0026#60;Books\u0026#62;\n    \u0026#60;title\u0026#62;Book name 1\u0026#60;/title\u0026#62;\n    \u0026#60;title\u0026#62;Book name 2\u0026#60;/title\u0026#62;\n    \u0026#60;title\u0026#62;Book name 3\u0026#60;/title\u0026#62;\n\u0026#60;/Books\u0026#62;",
		CodeXmlBODYCaption: "Path to element",
		XmlPathHintForBodyType: "XPath-like path to element. If namespace is needed, it\u0027s declared as \u0022Namespace prefix\u0022:\u0022Parameter path\u0022, for example, nsprefix1:parameterName"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});