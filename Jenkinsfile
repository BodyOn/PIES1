pipeline {
  agent any
  stages {
    stage('Mensagem') {
      steps {
        echo 'Gerando emails para notifica��o'
        mail(subject: '[Jenkins] Pipeline - BodyOn', body: 'Pipeline foi iniciado, este é um email de verificação.', to: 'ewaldoj18@gmail.com, marianaoliveirafernandes11@gmail.com, jejosu346@gmail.com')
        echo 'Emails enviados'
      }
    }

  }
}