define("CaseRatingFeedbackPageWithIconsResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		HowMuchDid: "Please select quality of our service",
		PostSuccess: "Your feedback has been sent successfully",
		AddCommentCaption: "Comment",
		AddCommentHint: "We are always looking at improving the quality of our services, so if you could provide us with some details and leave a comment that would be greatly appreciated!",
		CommentIsEmpty: "Comment text is empty!",
		PostButtonCaption: "Post comment",
		PostCommentFailed: "An error occurred. Comment wasn\u0027t added.",
		PostCommentSuccess: "Comment was successfully added",
		ThanksMessage: "Your feedback has been received. Thank you!"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		Background: {
			source: 3,
			params: {
				schemaName: "CaseRatingFeedbackPageWithIcons",
				resourceItemName: "Background",
				hash: "4f8c74d289663a79b1106142b109e055",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});