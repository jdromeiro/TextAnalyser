# TextAnalyser
A Web Service to sort paragraphs and calculate statistics about a text

## endpoint api/v1/text/statistics
Returns statistics about the string passed:
- number of words
- number of spaces
- number of hyphens

## endpoint api/v1/text/sort/{id}
Returns the text reorder according to a sort logic
1 - ByAlphabeticOrder
2 - ByReversedAlphabeticOrder
3 - ByReversedOrder
