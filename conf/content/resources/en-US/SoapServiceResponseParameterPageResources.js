﻿define("SoapServiceResponseParameterPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		CancelButtonCaption: "Cancel",
		CodeBODYCaption: "Path to element",
		CodeCOOKIECaption: "Cookie code",
		CodeHint: "Used by developers for interacting with the web service in Creatio source code",
		CodeHTTP_HEADERCaption: "Header code",
		CodeQUERY_STRINGCaption: "Code in query",
		CodeUNDEFINEDCaption: "Undefined",
		CodeURL_SEGMENTCaption: "Code in address",
		DataValueTypeHint: "Parameter with nested elements must have \u0022Object\u0022 data type",
		DuplicateNameMessage: "Parameter with this code already exists.",
		IsArrayHint: "Array parameter value cannot be set in \u0022Call web service\u0022 element in process designer. Please use \u0022Script task\u0022 element instead. Parameter with data type \u0022Object\u0022 must be an array",
		IsRequiredHint: "Select this checkbox to make this a required parameter in the Process Designer. The checkbox cannot be selected if the \u0026quot;Default value\u0026quot; field is filled in.",
		ObjectDataValueTypeHint: "Parameter with nested elements must have \u0022Object\u0022 data type",
		ParameterCaption: "Name",
		ParameterCode: "Code in method",
		ParameterDataType: "Data type",
		ParameterIsArray: "Is array",
		ParameterIsRequired: "Required",
		ParameterName: "Code in Creatio",
		ParameterType: "Parameter type",
		PathHintBodyPath: "Read more about creating requests",
		PathHintCookiePath: "Cookie with the following code will be added to the HTTP request",
		PathHintForBodyType: "XPath-like path to element. If namespace is needed, it\u0027s declared as \u0026quot;Namespace prefix\u0026quot;:\u0026quot;Parameter path\u0026quot;, for example, nsprefix1:parameterName",
		PathHintHeaderPath: "Header with the following code will be added to the HTTP request headers",
		PathHintQueryPath: "Request parameters will be specified in the complete call address in the following format: \u0022?paramCode=value\u0022",
		PathHintUriPath: "Must match the code in the method address in curly braces {}",
		SaveNewParameterButtonCaption: "OK",
		SequenceElementNameCaption: "Sequence element name",
		SequenceElementNameTip: "XML element name of every direct child element in array. For example, it will be \u0022title\u0022 in \u0022Books\u0022 array:\n\u0026#60;Books\u0026#62;\n    \u0026#60;title\u0026#62;Book name 1\u0026#60;/title\u0026#62;\n    \u0026#60;title\u0026#62;Book name 2\u0026#60;/title\u0026#62;\n    \u0026#60;title\u0026#62;Book name 3\u0026#60;/title\u0026#62;\n\u0026#60;/Books\u0026#62;",
		SequenceObjectElementNameTip: "XML element name of every direct child element in array. For example, it will be \u0022book\u0022 in \u0022Books\u0022 array:\n\u0026#60;Books\u0026#62;\n    \u0026#60;book\u0026#62;\n        \u0026#60;title\u0026#62;Book name 1\u0026#60;/title\u0026#62;\n        \u0026#60;author\u0026#62;Author 1\u0026#60;/author\u0026#62;\n    \u0026#60;/book\u0026#62;\n    \u0026#60;book\u0026#62;\n        \u0026#60;title\u0026#62;Book name 2\u0026#60;/title\u0026#62;\n        \u0026#60;author\u0026#62;Author 2\u0026#60;/author\u0026#62;\n    \u0026#60;/book\u0026#62;\n    \u0026#60;book\u0026#62;\n        \u0026#60;title\u0026#62;Book name 3\u0026#60;/title\u0026#62;\n        \u0026#60;author\u0026#62;Author 3\u0026#60;/author\u0026#62;\n    \u0026#60;/book\u0026#62;\n\u0026#60;/Books\u0026#62;",
		WarningMustSetIsObjectText: "You can select Object type only if Is Array attribute set",
		WarningNoBodyParameterForGetText: "GET Method cannot have body parameters",
		WrongCodeMessage: "Wrong code format",
		WrongNameMessage: "Invalid value. Use symbols: a-z, A-Z, 0-9. \u003C/br\u003E Symbol: 0-9 cannot be first.",
		WrongPrefixMessage: "Code of the method must contain prefix \u0022{0}\u0022"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});