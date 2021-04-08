mergeInto(LibraryManager.library, {
  aFunctionImplementedInJavaScriptLibraryFile: function(utf8String) {
    var jsString = UTF8ToString(utf8String);
    window.alert(jsString);
    aFunctionImplementedInHtmlFile(jsString);
    aFunctionImplementedInExternalJsFile(jsString);
  }
});
