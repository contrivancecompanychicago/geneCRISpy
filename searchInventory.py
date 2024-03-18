from fastapi import Body, FastAPI

app = FastAPI()

@app.post("/items/", response_model=searchInventoryArgs)
async def searchInventoryHandler(item: searchInventoryArgs = Body(...)) -> InventoryItem:
    # business logic here