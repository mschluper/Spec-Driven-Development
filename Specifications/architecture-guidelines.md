## Architecture Guidelines
- Use HTTP Context Accessor for Windows identity extraction
- Separate code-behind files (.razor.cs) for C# logic
- Use CSS isolation (.razor.css) for component-specific styling
- Use a ViewModel for each page
- Use @onchange instead of @bind for data binding
- Use UserContextService to get the current user's identity (to store in LastModifiedBy database table column)
