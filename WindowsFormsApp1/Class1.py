import sys

def find_text(text):
    f = open("info.txt", 'r')
    content = f.read()
    if text in content:
        return text
    else:
        return "Text not found"
    
text = sys.argv[1]
find_text(text)
    