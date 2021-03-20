#[tokio::main]
async fn main() {
    async {
        process_many().await.unwrap();
    }
    .await;
}

async fn process_many() -> Result<(), Box<dyn std::error::Error>> {
    process_one().await?;

    Ok(())
}

async fn process_one() -> Result<(), Box<dyn std::error::Error>> {
    panic!("something bad happened here");
}
