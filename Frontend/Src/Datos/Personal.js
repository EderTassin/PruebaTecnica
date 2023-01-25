
export const getPersonal = () => {
    

    const url = "https://localhost:44311/api/personal";

    const result = fetch(url)
    .then((response) => response.json())
    .then(
        
        (data) => console.log(data)
    )


    return result;

}